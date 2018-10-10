using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace jsreport.Types
{
    public class PdfOperation
    {        
        [JsonConverter(typeof(StringEnumConverter))]
        public PdfOperationType? Type { get; set; }
        public bool? MergeToFront { get; set; }
        public bool? RenderForEveryPage { get; set; }

        public string TemplateShortid { get; set; }
        public Template Template { get; set; }
    }
}
