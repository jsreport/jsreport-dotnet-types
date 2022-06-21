using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace jsreport.Types
{
    public class Chrome
    {       
        public decimal? Scale { get; set; }        
        public bool? DisplayHeaderFooter { get; set; }
        public bool? PrintBackground { get; set; }
        public string Footer { get; set; }        
        public bool Landscape { get; set; }
        public string PageRanges { get; set; }
        public string Format { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string MarginTop { get; set; }
        public string MarginRight { get; set; }
        public string MarginBottom { get; set; }
        public string MarginLeft { get; set; }
        public bool? WaitForJS { get; set; }
        public bool? WaitForNetworkIddle { get; set; }
        public string HeaderTemplate { get; set; }
        public string FooterTemplate { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MediaType? MediaType { get; set; }
        public string Url { get; set; }
    }
}
