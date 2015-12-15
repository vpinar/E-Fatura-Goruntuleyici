using System;

namespace SignatureValidator.DataTransferObject
{
    [Serializable]
    public class SignatureInfo
    {
        public DateTime? SigningTime { get; set; }
        public string UBLVersionID { get; set; }
    }
}