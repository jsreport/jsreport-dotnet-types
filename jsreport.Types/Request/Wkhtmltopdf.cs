using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace jsreport.Types
{
    public class Wkhtmltopdf
    {
        public string Header { get; set; }
        public string HeaderHeight { get; set; }
        public string Footer { get; set; }
        public string FooterHeight { get; set; }
        public string Dpi { get; set; }
        public string MarginBottom { get; set; }
        public string MarginLeft { get; set; }
        public string MarginRight { get; set; }
        public string MarginTop { get; set; }
        public string PageSize { get; set; }
        public string PageHeight { get; set; }
        public string PageWidth { get; set; }
        public string Cover { get; set; }
        public bool? Toc { get; set; }
        public string TocHeaderText { get; set; }
        public string TocLevelIndentation { get; set; }
        public string TocTextSizeShrink { get; set; }
        public string Title { get; set; }
        public bool? KeepRelativeLinks { get; set; }
        public bool? DisableSmartShrinking { get; set; }
        public bool? PrintMediaType { get; set; }
        public int? JavascriptDelay { get; set; }
        public string WindowStatus { get; set; }        

        [JsonConverter(typeof(StringEnumConverter))]
        public WkhtmltopdfOrientation? Orientation { get; set; }
    }
}
