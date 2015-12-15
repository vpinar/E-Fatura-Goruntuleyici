using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace EFaturaGoruntuleyici.Utils
{
    public static class Utils
    {
        public enum InvoiceRendeMode
        {
            /// <summary>
            /// Firmanın özelleşmiş Fatura formatını kullan. Yoksa boş veri getir.
            /// </summary>
            Custom,
            /// <summary>
            /// Fatura Gösterimi için Gelirler idaresi baçkanığının fatura formatını kullan.
            /// </summary>
            GIB
        }

        public static string Invoice2Html(string invoiceXmlIcerik, InvoiceRendeMode invoiceRendeMode)
        {
            var invoiceXmlDocument = new XmlDocument();

            if (invoiceXmlIcerik.IndexOf('<') > 0)
            {
                invoiceXmlIcerik = invoiceXmlIcerik.Substring(invoiceXmlIcerik.IndexOf('<'));
            }

            invoiceXmlDocument.LoadXml(invoiceXmlIcerik);

            var styleSheetXmlContent = string.Empty;
            if (invoiceRendeMode == InvoiceRendeMode.Custom)
            {
                var embeddedDocumentBinaryObjectList = invoiceXmlDocument.GetElementsByTagName("EmbeddedDocumentBinaryObject", "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2");
                var embededStyleSheetXmlContent = string.Empty;

                foreach (XmlNode item in embeddedDocumentBinaryObjectList)
                {
                    //XSLT tipinde tanımlanmış var ise onu kullan.
                    if (item.Attributes["DocumentType"] != null && item.Attributes["DocumentType"].Value == "XSLT")
                    {
                        embededStyleSheetXmlContent = item.InnerText;
                        break;
                    }
                    else if (item.Attributes["mimeCode"] != null && item.Attributes["mimeCode"].Value == "application/xml")
                    {
                        embededStyleSheetXmlContent = item.InnerText;
                        break;
                    }
                }

                styleSheetXmlContent = Encoding.UTF8.GetString(Convert.FromBase64String(embededStyleSheetXmlContent));
            }
            else if (invoiceRendeMode == InvoiceRendeMode.GIB)
            {
                styleSheetXmlContent = System.IO.File.ReadAllText("Files/FaturaFormat.xslt");
            }

            //Xml bilgisi içinde BOM olması ihtimaline karşı < karaketerinden önceki bütün bilgiler silinir.
            if (styleSheetXmlContent.IndexOf('<') > 0)
            {
                styleSheetXmlContent = styleSheetXmlContent.Substring(styleSheetXmlContent.IndexOf('<'));
            }

            var swResult = new StringWriter();

            if (!string.IsNullOrEmpty(styleSheetXmlContent))
            {
                var xmlsheet = new XmlDocument();
                xmlsheet.LoadXml(styleSheetXmlContent);

                var myXslTrans = new XslCompiledTransform();
                myXslTrans.Load(xmlsheet);

                var xpathDoc = new XPathDocument(new MemoryStream(Encoding.UTF8.GetBytes(invoiceXmlIcerik)));
                myXslTrans.Transform(xpathDoc, null, swResult);
            }

            return swResult.ToString().Replace("charset=utf-16", "charset=utf-8");
        }
        private class Imza
        {
            public Guid Id { get; set; }
            public string ImzaXmlNode { get; set; }
        }

        public static string GetSignatureXmlFromInvoice(string signedXml)
        {
            var result = string.Empty;
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(signedXml);

            var nodes = xmlDoc.GetElementsByTagName("Signature", "http://www.w3.org/2000/09/xmldsig#");

            foreach (XmlNode item in nodes)
            {
                result = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" + Environment.NewLine + item.OuterXml;
                break;
            }

            return result;
        }

    }
}
