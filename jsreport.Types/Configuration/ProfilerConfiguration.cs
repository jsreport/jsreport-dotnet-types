using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class ProfilerConfiguration
    {
        [DataMember(Name = "profiler_maxProfilesHistory")]
        public int? MaxProfilesHistory { get; set; }

        [DataMember(Name = "profiler_maxDiffSize")]
        public string MaxDiffSize { get; set; }

        [DataMember(Name = "profiler_defaultMode")]
        public ProfilerMode? DefaultMode { get; set; }
    }
}
