using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class SampleTemplateConfiguration
    {        
        [DataMember(Name = "extensions_sample-template_createSamples")]
        public bool CreateSamples { get; set; }
    }   
}
