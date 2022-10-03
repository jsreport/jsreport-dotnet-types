using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class SchedulingConfiguration
    {
        [DataMember(Name = "extensions_scheduling_interval")]
        public int? Interval { get; set; }

        [DataMember(Name = "extensions_scheduling_minScheduleInterval")]
        public int? MinScheduleInterval { get; set; }

        [DataMember(Name = "extensions_scheduling_misfireTreshold")]
        public int? MisfireTreshold { get; set; }

        [DataMember(Name = "extensions_scheduling_maxParallelJobs")]
        public int? MaxParallelJobs { get; set; }

        [DataMember(Name = "extensions_scheduling_taskPingTimeout")]
        public int? TaskPingTimeout { get; set; }

        [DataMember(Name = "extensions_scheduling_cleanScheduleHistoryInterval")]
        public int? CleanScheduleHistoryInterval { get; set; }

        [DataMember(Name = "extensions_scheduling_maxHistoryPerSchedule")]
        public int? MaxHistoryPerSchedule { get; set; }
    }
}
