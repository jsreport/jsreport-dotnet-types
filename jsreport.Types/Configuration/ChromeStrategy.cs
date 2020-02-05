using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public enum ChromeStrategy
    {        
        [EnumMember(Value = "dedicated-process")]
        DedicatedProcess,
        [EnumMember(Value = "chrome-pool")]
        ChromePool                    
    }
}
