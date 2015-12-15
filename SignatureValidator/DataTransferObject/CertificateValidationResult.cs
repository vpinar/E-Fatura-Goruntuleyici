using System;
using System.Collections.Generic;

namespace SignatureValidator.DataTransferObject
{
    [Serializable]
    public class CertificateValidationResult
    {
        public List<ValidationResult> ValidationResultList { get; set; }
        public bool Successful { get; set; }
    }
}
