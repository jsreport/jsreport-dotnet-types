using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public enum ProfilerMode
    {
        [EnumMember(Value = "standard")]
        Standard,
        [EnumMember(Value = "full")]
        Full,
        [EnumMember(Value = "disabled")]
        Disabled
    }
}
