using System;
using System.Collections.Generic;

namespace SignatureValidator.DataTransferObject
{
    [Serializable]
    public class SignatureValidationResult
    {
        public bool Successful { get; set; }
        public string ResultText { get; set; }
        public List<ValidationResult> ValidationResultList { get; set; }
    }
}
