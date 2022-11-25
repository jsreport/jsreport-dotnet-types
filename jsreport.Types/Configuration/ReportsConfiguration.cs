using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class ReportsConfiguration
    {
        [DataMember(Name = "extensions_reports_cleanInterval")]
        public string CleanInterval { get; set; }

        [DataMember(Name = "extensions_reports_cleanThreshold")]
        public string CleanThreshold { get; set; }

        [DataMember(Name = "extensions_reports_cleanParallelLimit")]
        public int? CleanParallelLimit { get; set; }
    }
}
