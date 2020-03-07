using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class EncryptionConfiguration
    {
        [DataMember(Name = "encryption_secretKey")]
        public string SecretKey { get; set; }
    }
}
