using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Text;

namespace jsreport.Types
{
    public class Phantom
    {
        /// <summary>
        /// Paper margin like 2cm, see phantom doc for details http://phantomjs.org/
        /// </summary>
        public string Margin { get; set; }

        /// <summary>
        /// Html used for page header, you can use special tags to insert page numbers: {#pageNum}/{#numPages}
        /// </summary>
        public string Header { get; set; }

        /// <summary>
        /// Height of header like 2cm
        /// </summary>
        public string HeaderHeight { get; set; }

        /// <summary>
        /// Html used for page footer, you can use special tags to insert page numbers: {#pageNum}/{#numPages}
        /// </summary> 
        public string Footer { get; set; }

        /// <summary>
        /// Height of footer like 2cm
        /// </summary>
        public string FooterHeight { get; set; }

        /// <summary>
        /// Paper orientation, possible values "landscape" and "portrait"
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public PhantomOrientation? Orientation { get; set; }

        /// <summary>
        /// Paper format, possible values "A5", "A4", "A3", "Letter", "Tabloid", "Legal"
        /// width or height specification takes precedence
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public PhantomFormat? Format { get; set; }

        /// <summary>
        /// Paper width like 2cm
        /// </summary>
        public string Width { get; set; }

        /// <summary>
        /// Paper height like 2cm
        /// </summary>
        public string Height { get; set; }

        public string Url { get; set; }

        /// <summary>
        /// Milliseconds to wait for js rendering like 1000
        /// </summary>
        public int PrintDelay { get; set; }

        /// <summary>
        /// Block all the javascript on the page
        /// </summary>
        public bool BlockJavaScript { get; set; }

        /// <summary>
        /// The printing waits for the trigger, see http://jsreport.net/learn/phantom-pdf
        /// </summary>
        public bool WaitForJS { get; set; }

        /// <summary>
        /// Timeout for external resources like scripts or css load
        /// </summary>
        public int ResourceTimeout { get; set; }
    }
}
