﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class BaseConfiguration
    {
        [DataMember(Name = "extensions_base_url")]
        public string Url { get; set; }
    }
}
