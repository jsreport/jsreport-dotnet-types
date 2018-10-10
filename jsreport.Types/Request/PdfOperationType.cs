using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public enum PdfOperationType
    {
        [EnumMember(Value = "append")]
        Append,
        [EnumMember(Value = "prepend")]
        Prepend,
        [EnumMember(Value = "merge")]
        Merge
    }
}
