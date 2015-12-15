using Html2Pdf;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EFaturaGoruntuleyici
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnFaturaSec_Click(object sende, EventArgs e)
        {
            var dosyaIcerik = string.Empty;
            var result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog.FileName;

                dosyaIcerik = File.ReadAllText(file);

                tcFaturaBilgileri.Visible = true;

                wbFaturaXml.DocumentText = dosyaIcerik.StartsWith("<?xml version=\"1.0\"") ? dosyaIcerik : "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" + dosyaIcerik;
                wbFaturaHtml.DocumentText = Utils.Utils.Invoice2Html(dosyaIcerik, Utils.Utils.InvoiceRenderMode.Custom);
                wbGibFaturaGorunumu.DocumentText = Utils.Utils.Invoice2Html(dosyaIcerik, Utils.Utils.InvoiceRenderMode.GIB);
                wbSignatureXml.DocumentText = Utils.Utils.GetSignatureXmlFromInvoice(dosyaIcerik);

                var validationResult = SignatureValidationUtil.ValidateSignatureFromXml(dosyaIcerik);

                lblImzaDorulamaSonucudata.Text = validationResult.SignatureValidationResult.ResultText;
                lblImzaDorulamaSonucudata.ForeColor = validationResult.SignatureValidationResult.Successful ? Color.Green : Color.Red;
                lblImzalamaZamani.Text = validationResult.SignatureInfo.SigningTime.ToString();
                lblUBLVersiyonNo.Text = validationResult.SignatureInfo.UBLVersionID;

                dataGridCertControl.DataSource = validationResult.CertificateValidationResult.ValidationResultList;
            }
            else
            {

            }

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new About().ShowDialog(this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.FileName = "Fatura.pdf";
                if (DialogResult.OK != saveFileDialog1.ShowDialog())
                    return;
                var pdfContent = Html2PdfConverter.ConvertHtml2PDF(wbGibFaturaGorunumu.DocumentText);
                File.WriteAllBytes(saveFileDialog1.FileName, pdfContent);
            }
        }

        private void dataGridCertControl_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridCertControl.Columns[e.ColumnIndex].Name == "SonucSimge")
            {
                if (Convert.ToBoolean(dataGridCertControl.Rows[e.RowIndex].Cells["Successful"].Value))
                {
                    e.Value = Image.FromFile("Images/Verified.png");
                }
                else
                {
                    e.Value = Image.FromFile("Images/pdf_White.png");
                }
            }
        }

        private void btCustomPdf_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.FileName = "Fatura_Firma_Gorunum.pdf";
                if (DialogResult.OK != saveFileDialog1.ShowDialog())
                    return;
                var pdfContent = Html2PdfConverter.ConvertHtml2PDF(wbFaturaHtml.DocumentText);
                File.WriteAllBytes(saveFileDialog1.FileName, pdfContent);
            }
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            var objPrint = wbGibFaturaGorunumu;

            if (tcFaturaBilgileri.SelectedTab != null && tcFaturaBilgileri.SelectedTab.Name == "tpGibFaturaGorunumu")
            {
                objPrint = wbFaturaHtml;
            }

            objPrint.ShowPrintPreviewDialog();
        }

    }
}