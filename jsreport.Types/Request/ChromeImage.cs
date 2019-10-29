using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace jsreport.Types
{
    public class ChromeImage
    {       
        public string Type { get; set; }
        public decimal? Quality { get; set; }
        public bool? FullPage { get; set; }
        public decimal? ClipX { get; set; }
        public decimal? ClipY { get; set; }
        public decimal? ClipHeight { get; set; }
        public decimal? ClipWidth { get; set; }
        public bool? OmitBackground { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public MediaType? MediaType { get; set; }
        public bool? WaitForJS { get; set; }
        public bool? WaitForNetworkIddle { get; set; }
        public string Url { get; set; }
    }
}
