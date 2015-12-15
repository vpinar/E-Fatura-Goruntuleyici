using System;
using System.Xml.Serialization;

namespace SignatureValidator.DataTransferObject
{
    [Serializable]
    public class SignedDocumentValidationResult
    {
        public CertificateValidationResult CertificateValidationResult { get; set; }
        public SignatureValidationResult SignatureValidationResult { get; set; }
        public string DosyaAdi { get; set; }
        [XmlIgnore]
        public System.Security.Cryptography.X509Certificates.X509Certificate2 Certificate { get; set; }
        public SignatureInfo SignatureInfo { get; set; }

    }
}
