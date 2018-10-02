using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public enum MediaType
    {
        [EnumMember(Value = "print")]
        Print,
        [EnumMember(Value = "screen")]
        Screen
    }
}
