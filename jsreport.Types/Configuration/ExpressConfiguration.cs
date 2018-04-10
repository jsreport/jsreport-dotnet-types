using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class ExpressConfiguration
    {
        [DataMember(Name = "express_inputRequestLimit")]
        public string InputRequestLimit { get; set; }
    }
}
