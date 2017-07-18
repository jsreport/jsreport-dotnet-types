using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class BaseConfiguration
    {
        [DataMember(Name = "base_url")]
        public string Url { get; set; }
    }
}
