using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class UnoconvConfiguration
    {
        [DataMember(Name = "extensions_unoconv_command")]
        public string Command { get; set; }
    }
}
