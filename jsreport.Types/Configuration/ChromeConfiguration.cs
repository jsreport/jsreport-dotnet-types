﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class ChromeConfiguration
    {
        [DataMember(Name = "chrome_timeout")]
        public int? Timeout { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]     
        public ChromeStrategy? Strategy { get; set; }

        [DataMember(Name = "chrome_numberOfWorkers")]
        public int? NumberOfWorkers { get; set; }
    }
}
