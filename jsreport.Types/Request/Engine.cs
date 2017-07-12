using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public enum Engine
    {
        [EnumMember(Value = "handlebars")]
        Handlebars,
        [EnumMember(Value = "jsrender")]
        JsRender,
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "jade")]
        Jade,
        [EnumMember(Value = "ejs")]
        EJS
    }
}
