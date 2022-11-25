using System;
using System.Collections.Generic;
using System.Text;

namespace jsreport.Types
{
    public class PdfMeta
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Subject { get; set; }
        public string Keywords { get; set; }
        public string Creator { get; set; }
        public string Producer { get; set; }
        /// <summary>
        /// serialized json key-value pairs
        /// JsonSerializer.Serialize(new { a = "a" } )
        /// </summary>        
        public string Custom { get; set; }
    }
}
