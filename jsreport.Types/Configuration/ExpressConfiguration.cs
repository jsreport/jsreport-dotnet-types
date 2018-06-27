using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class ExpressConfiguration
    {
        [DataMember(Name = "extensions_express_inputRequestLimit")]
        public string InputRequestLimit { get; set; }
    }
}
