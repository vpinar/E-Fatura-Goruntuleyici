using System;
using System.ComponentModel;

namespace SignatureValidator.DataTransferObject
{
    [Serializable]
    public class ValidationResult
    {
        public bool Successful { get; set; }
        public string CheckText { get; set; }
        public string ResultText { get; set; }
        [Browsable(false)]
        public string Result { get; set; }
      
    }
}