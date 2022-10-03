using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class NPMConfiguration
    {
        [DataMember(Name = "extensions_npm_allowedModules")]
        public string AllowedModules { get; set; }
    }
}
