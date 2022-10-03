using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class WorkersConfiguration
    {
        [DataMember(Name = "workers_numberOfWorkers")]
        public int? NumberOfWorkers { get; set; }
    }
}
