namespace EFaturaGoruntuleyici
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainMenu = new System.Windows.Forms.ToolStrip();
            this.btnFaturaSec = new System.Windows.Forms.ToolStripButton();
            this.btCustomPdf = new System.Windows.Forms.ToolStripButton();
            this.btGIBPdf = new System.Windows.Forms.ToolStripButton();
            this.btPrint = new System.Windows.Forms.ToolStripButton();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tcFaturaBilgileri = new System.Windows.Forms.TabControl();
            this.tpFaturaGorunumu = new System.Windows.Forms.TabPage();
            this.wbFaturaHtml = new System.Windows.Forms.WebBrowser();
            this.tpGibFaturaGorunumu = new System.Windows.Forms.TabPage();
            this.wbGibFaturaGorunumu = new System.Windows.Forms.WebBrowser();
            this.tpFaturaXml = new System.Windows.Forms.TabPage();
            this.wbFaturaXml = new System.Windows.Forms.WebBrowser();
            this.tpImzaBilgileri = new System.Windows.Forms.TabPage();
            this.wbSignatureXml = new System.Windows.Forms.WebBrowser();
            this.tpImzaDogrulamsonuc = new System.Windows.Forms.TabPage();
            this.dataGridCertControl = new System.Windows.Forms.DataGridView();
            this.SonucSimge = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnlImzaDogrulamaSonuc = new System.Windows.Forms.Panel();
            this.lnl99 = new System.Windows.Forms.Label();
            this.lblUBLVersiyonNo = new System.Windows.Forms.Label();
            this.lblImzalamaZamani = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblImzaDorulamaSonucudata = new System.Windows.Forms.Label();
            this.lblImzadogrulamaSonuc = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.tcFaturaBilgileri.SuspendLayout();
            this.tpFaturaGorunumu.SuspendLayout();
            this.tpGibFaturaGorunumu.SuspendLayout();
            this.tpFaturaXml.SuspendLayout();
            this.tpImzaBilgileri.SuspendLayout();
            this.tpImzaDogrulamsonuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCertControl)).BeginInit();
            this.pnlImzaDogrulamaSonuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFaturaSec,
            this.btCustomPdf,
            this.btGIBPdf,
            this.btPrint,
            this.btnAbout});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(1139, 55);
            this.mainMenu.TabIndex = 1;
            // 
            // btnFaturaSec
            // 
            this.btnFaturaSec.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFaturaSec.Image = ((System.Drawing.Image)(resources.GetObject("btnFaturaSec.Image")));
            this.btnFaturaSec.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFaturaSec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFaturaSec.Name = "btnFaturaSec";
            this.btnFaturaSec.Size = new System.Drawing.Size(52, 52);
            this.btnFaturaSec.Text = "Fatura Seç";
            this.btnFaturaSec.ToolTipText = "Lütfen görüntülek istediğiniz fatura Xml dosyasını seçiniz.";
            this.btnFaturaSec.Click += new System.EventHandler(this.btnFaturaSec_Click);
            // 
            // btCustomPdf
            // 
            this.btCustomPdf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btCustomPdf.Image = ((System.Drawing.Image)(resources.GetObject("btCustomPdf.Image")));
            this.btCustomPdf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btCustomPdf.Name = "btCustomPdf";
            this.btCustomPdf.Size = new System.Drawing.Size(36, 52);
            this.btCustomPdf.Text = "toolStripButton2";
            this.btCustomPdf.Click += new System.EventHandler(this.btCustomPdf_Click);
            // 
            // btGIBPdf
            // 
            this.btGIBPdf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btGIBPdf.Image = ((System.Drawing.Image)(resources.GetObject("btGIBPdf.Image")));
            this.btGIBPdf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btGIBPdf.Name = "btGIBPdf";
            this.btGIBPdf.Size = new System.Drawing.Size(36, 52);
            this.btGIBPdf.Text = "PDF";
            this.btGIBPdf.ToolTipText = "Dosyayı PDF olarak kaydet.";
            this.btGIBPdf.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btPrint
            // 
            this.btPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btPrint.Image = ((System.Drawing.Image)(resources.GetObject("btPrint.Image")));
            this.btPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(36, 52);
            this.btPrint.Text = "btPrint";
            this.btPrint.ToolTipText = "Faturayı yazdırmak için tıklayınız.";
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(36, 52);
            this.btnAbout.Text = "Hakkında";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tcFaturaBilgileri
            // 
            this.tcFaturaBilgileri.Controls.Add(this.tpFaturaGorunumu);
            this.tcFaturaBilgileri.Controls.Add(this.tpGibFaturaGorunumu);
            this.tcFaturaBilgileri.Controls.Add(this.tpFaturaXml);
            this.tcFaturaBilgileri.Controls.Add(this.tpImzaBilgileri);
            this.tcFaturaBilgileri.Controls.Add(this.tpImzaDogrulamsonuc);
            this.tcFaturaBilgileri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcFaturaBilgileri.Location = new System.Drawing.Point(0, 55);
            this.tcFaturaBilgileri.Name = "tcFaturaBilgileri";
            this.tcFaturaBilgileri.SelectedIndex = 0;
            this.tcFaturaBilgileri.Size = new System.Drawing.Size(1139, 583);
            this.tcFaturaBilgileri.TabIndex = 2;
            this.tcFaturaBilgileri.Visible = false;
            // 
            // tpFaturaGorunumu
            // 
            this.tpFaturaGorunumu.Controls.Add(this.wbFaturaHtml);
            this.tpFaturaGorunumu.Location = new System.Drawing.Point(4, 22);
            this.tpFaturaGorunumu.Name = "tpFaturaGorunumu";
            this.tpFaturaGorunumu.Padding = new System.Windows.Forms.Padding(3);
            this.tpFaturaGorunumu.Size = new System.Drawing.Size(1131, 557);
            this.tpFaturaGorunumu.TabIndex = 0;
            this.tpFaturaGorunumu.Text = "Fatura Görünümü";
            this.tpFaturaGorunumu.UseVisualStyleBackColor = true;
            // 
            // wbFaturaHtml
            // 
            this.wbFaturaHtml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbFaturaHtml.Location = new System.Drawing.Point(3, 3);
            this.wbFaturaHtml.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbFaturaHtml.Name = "wbFaturaHtml";
            this.wbFaturaHtml.Size = new System.Drawing.Size(1125, 551);
            this.wbFaturaHtml.TabIndex = 0;
            // 
            // tpGibFaturaGorunumu
            // 
            this.tpGibFaturaGorunumu.Controls.Add(this.wbGibFaturaGorunumu);
            this.tpGibFaturaGorunumu.Location = new System.Drawing.Point(4, 22);
            this.tpGibFaturaGorunumu.Name = "tpGibFaturaGorunumu";
            this.tpGibFaturaGorunumu.Size = new System.Drawing.Size(1131, 557);
            this.tpGibFaturaGorunumu.TabIndex = 4;
            this.tpGibFaturaGorunumu.Text = "GİB Fatura Görünümü";
            this.tpGibFaturaGorunumu.UseVisualStyleBackColor = true;
            // 
            // wbGibFaturaGorunumu
            // 
            this.wbGibFaturaGorunumu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbGibFaturaGorunumu.Location = new System.Drawing.Point(0, 0);
            this.wbGibFaturaGorunumu.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbGibFaturaGorunumu.Name = "wbGibFaturaGorunumu";
            this.wbGibFaturaGorunumu.Size = new System.Drawing.Size(1131, 557);
            this.wbGibFaturaGorunumu.TabIndex = 0;
            // 
            // tpFaturaXml
            // 
            this.tpFaturaXml.Controls.Add(this.wbFaturaXml);
            this.tpFaturaXml.Location = new System.Drawing.Point(4, 22);
            this.tpFaturaXml.Name = "tpFaturaXml";
            this.tpFaturaXml.Size = new System.Drawing.Size(1131, 557);
            this.tpFaturaXml.TabIndex = 2;
            this.tpFaturaXml.Text = "Fatura Xml Bilgisi";
            this.tpFaturaXml.UseVisualStyleBackColor = true;
            // 
            // wbFaturaXml
            // 
            this.wbFaturaXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbFaturaXml.Location = new System.Drawing.Point(0, 0);
            this.wbFaturaXml.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbFaturaXml.Name = "wbFaturaXml";
            this.wbFaturaXml.Size = new System.Drawing.Size(1131, 557);
            this.wbFaturaXml.TabIndex = 0;
            // 
            // tpImzaBilgileri
            // 
            this.tpImzaBilgileri.Controls.Add(this.wbSignatureXml);
            this.tpImzaBilgileri.Location = new System.Drawing.Point(4, 22);
            this.tpImzaBilgileri.Name = "tpImzaBilgileri";
            this.tpImzaBilgileri.Padding = new System.Windows.Forms.Padding(3);
            this.tpImzaBilgileri.Size = new System.Drawing.Size(1131, 557);
            this.tpImzaBilgileri.TabIndex = 1;
            this.tpImzaBilgileri.Text = "İmza XML Bilgileri";
            this.tpImzaBilgileri.UseVisualStyleBackColor = true;
            // 
            // wbSignatureXml
            // 
            this.wbSignatureXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbSignatureXml.Location = new System.Drawing.Point(3, 3);
            this.wbSignatureXml.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbSignatureXml.Name = "wbSignatureXml";
            this.wbSignatureXml.Size = new System.Drawing.Size(1125, 551);
            this.wbSignatureXml.TabIndex = 0;
            // 
            // tpImzaDogrulamsonuc
            // 
            this.tpImzaDogrulamsonuc.Controls.Add(this.dataGridCertControl);
            this.tpImzaDogrulamsonuc.Controls.Add(this.pnlImzaDogrulamaSonuc);
            this.tpImzaDogrulamsonuc.Location = new System.Drawing.Point(4, 22);
            this.tpImzaDogrulamsonuc.Name = "tpImzaDogrulamsonuc";
            this.tpImzaDogrulamsonuc.Size = new System.Drawing.Size(1131, 557);
            this.tpImzaDogrulamsonuc.TabIndex = 3;
            this.tpImzaDogrulamsonuc.Text = "İmza Doğrulama Sonucu";
            this.tpImzaDogrulamsonuc.UseVisualStyleBackColor = true;
            // 
            // dataGridCertControl
            // 
            this.dataGridCertControl.AllowUserToAddRows = false;
            this.dataGridCertControl.AllowUserToDeleteRows = false;
            this.dataGridCertControl.AllowUserToOrderColumns = true;
            this.dataGridCertControl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCertControl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SonucSimge});
            this.dataGridCertControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridCertControl.Location = new System.Drawing.Point(0, 94);
            this.dataGridCertControl.Name = "dataGridCertControl";
            this.dataGridCertControl.ReadOnly = true;
            this.dataGridCertControl.Size = new System.Drawing.Size(1131, 150);
            this.dataGridCertControl.TabIndex = 1;
            this.dataGridCertControl.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridCertControl_CellFormatting);
            // 
            // SonucSimge
            // 
            this.SonucSimge.HeaderText = "SonucSimge";
            this.SonucSimge.Name = "SonucSimge";
            this.SonucSimge.ReadOnly = true;
            // 
            // pnlImzaDogrulamaSonuc
            // 
            this.pnlImzaDogrulamaSonuc.Controls.Add(this.lnl99);
            this.pnlImzaDogrulamaSonuc.Controls.Add(this.lblUBLVersiyonNo);
            this.pnlImzaDogrulamaSonuc.Controls.Add(this.lblImzalamaZamani);
            this.pnlImzaDogrulamaSonuc.Controls.Add(this.label1);
            this.pnlImzaDogrulamaSonuc.Controls.Add(this.lblImzaDorulamaSonucudata);
            this.pnlImzaDogrulamaSonuc.Controls.Add(this.lblImzadogrulamaSonuc);
            this.pnlImzaDogrulamaSonuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlImzaDogrulamaSonuc.Location = new System.Drawing.Point(0, 0);
            this.pnlImzaDogrulamaSonuc.Name = "pnlImzaDogrulamaSonuc";
            this.pnlImzaDogrulamaSonuc.Size = new System.Drawing.Size(1131, 94);
            this.pnlImzaDogrulamaSonuc.TabIndex = 0;
            // 
            // lnl99
            // 
            this.lnl99.AutoSize = true;
            this.lnl99.Location = new System.Drawing.Point(9, 61);
            this.lnl99.Name = "lnl99";
            this.lnl99.Size = new System.Drawing.Size(94, 13);
            this.lnl99.TabIndex = 4;
            this.lnl99.Text = "UBL Versiyon No :";
            // 
            // lblUBLVersiyonNo
            // 
            this.lblUBLVersiyonNo.AutoSize = true;
            this.lblUBLVersiyonNo.Location = new System.Drawing.Point(145, 61);
            this.lblUBLVersiyonNo.Name = "lblUBLVersiyonNo";
            this.lblUBLVersiyonNo.Size = new System.Drawing.Size(92, 13);
            this.lblUBLVersiyonNo.TabIndex = 3;
            this.lblUBLVersiyonNo.Text = "lblUBLVersiyonNo";
            // 
            // lblImzalamaZamani
            // 
            this.lblImzalamaZamani.AutoSize = true;
            this.lblImzalamaZamani.Location = new System.Drawing.Point(145, 34);
            this.lblImzalamaZamani.Name = "lblImzalamaZamani";
            this.lblImzalamaZamani.Size = new System.Drawing.Size(89, 13);
            this.lblImzalamaZamani.TabIndex = 3;
            this.lblImzalamaZamani.Text = "İmzalama Zamanı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "İmzalama Zamanı :";
            // 
            // lblImzaDorulamaSonucudata
            // 
            this.lblImzaDorulamaSonucudata.AutoSize = true;
            this.lblImzaDorulamaSonucudata.Location = new System.Drawing.Point(145, 4);
            this.lblImzaDorulamaSonucudata.Name = "lblImzaDorulamaSonucudata";
            this.lblImzaDorulamaSonucudata.Size = new System.Drawing.Size(144, 13);
            this.lblImzaDorulamaSonucudata.TabIndex = 1;
            this.lblImzaDorulamaSonucudata.Text = "lblImzaGorulamaSonucuData";
            // 
            // lblImzadogrulamaSonuc
            // 
            this.lblImzadogrulamaSonuc.AutoSize = true;
            this.lblImzadogrulamaSonuc.Location = new System.Drawing.Point(9, 4);
            this.lblImzadogrulamaSonuc.Name = "lblImzadogrulamaSonuc";
            this.lblImzadogrulamaSonuc.Size = new System.Drawing.Size(129, 13);
            this.lblImzadogrulamaSonuc.TabIndex = 0;
            this.lblImzadogrulamaSonuc.Text = "İmza Doğrulama Sonucu :";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1139, 638);
            this.Controls.Add(this.tcFaturaBilgileri);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "E-Fatura Görüntüleyici";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tcFaturaBilgileri.ResumeLayout(false);
            this.tpFaturaGorunumu.ResumeLayout(false);
            this.tpGibFaturaGorunumu.ResumeLayout(false);
            this.tpFaturaXml.ResumeLayout(false);
            this.tpImzaBilgileri.ResumeLayout(false);
            this.tpImzaDogrulamsonuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCertControl)).EndInit();
            this.pnlImzaDogrulamaSonuc.ResumeLayout(false);
            this.pnlImzaDogrulamaSonuc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip mainMenu;
        private System.Windows.Forms.ToolStripButton btnFaturaSec;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tcFaturaBilgileri;
        private System.Windows.Forms.TabPage tpFaturaGorunumu;
        private System.Windows.Forms.TabPage tpImzaBilgileri;
        private System.Windows.Forms.WebBrowser wbFaturaHtml;
        private System.Windows.Forms.TabPage tpFaturaXml;
        private System.Windows.Forms.WebBrowser wbFaturaXml;
        private System.Windows.Forms.TabPage tpGibFaturaGorunumu;
        private System.Windows.Forms.WebBrowser wbGibFaturaGorunumu;
        private System.Windows.Forms.TabPage tpImzaDogrulamsonuc;
        private System.Windows.Forms.WebBrowser wbSignatureXml;
        private System.Windows.Forms.Panel pnlImzaDogrulamaSonuc;
        private System.Windows.Forms.Label lblImzaDorulamaSonucudata;
        private System.Windows.Forms.Label lblImzadogrulamaSonuc;
        private System.Windows.Forms.Label lnl99;
        private System.Windows.Forms.Label lblUBLVersiyonNo;
        private System.Windows.Forms.Label lblImzalamaZamani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripButton btGIBPdf;
        private System.Windows.Forms.DataGridView dataGridCertControl;
        private System.Windows.Forms.DataGridViewImageColumn SonucSimge;
        private System.Windows.Forms.ToolStripButton btCustomPdf;
        private System.Windows.Forms.ToolStripButton btPrint;

    }
}

