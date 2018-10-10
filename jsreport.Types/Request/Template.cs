using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace jsreport.Types
{
    public class Template
    {
        public Template ()
        {            
        }         

        public string _id { get; set; }

        /// <summary>
        /// Unique 9 alfanum id
        /// </summary>
        public string Shortid { get; set; }

        /// <summary>
        /// Content of report, most often this is html with javasript templating engines
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Javascript helper functions in format: function a() { }; function b() { };
        /// </summary>
        public string Helpers { get; set; }

        /// <summary>
        /// Used javascript templating engine like "jsrender" or "handlebars"
        /// </summary>  
        [JsonConverter(typeof(StringEnumConverter))]
        public Engine? Engine { get; set; } 

        /// <summary>
        /// Used recipe defining rendering process like "html", "phantom-pdf" or "fop"
        /// </summary> 
        [JsonConverter(typeof(StringEnumConverter))]
        public Recipe? Recipe { get; set; }       

        /// <summary>
        /// Readable name, does not need to be unique
        /// </summary>
        public string Name { get; set; }

        public Chrome Chrome { get; set; }

        public HtmlToXlsx HtmlToXlsx { get; set; }

        public Phantom Phantom { get; set; }

        public Wkhtmltopdf Wkhtmltopdf { get; set; }

        public XlsxTemplate XlsxTemplate { get; set; }

        public IList<Script> Scripts { get; set; }

        public IList<PdfOperation> PdfOperations { get; set; }
    }
}
