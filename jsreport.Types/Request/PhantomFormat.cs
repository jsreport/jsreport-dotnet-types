using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public enum PhantomFormat
    {         
        [EnumMember(Value = "A4")]
        A4,
        [EnumMember(Value = "A5")]
        A5,        
        [EnumMember(Value = "A3")]
        A3,
        [EnumMember(Value = "Letter")]
        Letter,
        [EnumMember(Value = "Tabloid")]
        Tabloid,
        [EnumMember(Value = "Legal")]
        Legal
    }
}
