using System;
using System.Collections.Generic;
using System.Text;

namespace jsreport.Types
{
    public class ReportMeta
    {
        /// <summary>
        /// Logs produced during rendering. 
        /// Filled only when RenderingRequest.Options.Debug.LogsToResponseHeader=true
        /// </summary>
        public IEnumerable<LogEntry> Logs { get; set; }

        /// <summary>
        /// Report content type like application/pdf
        /// </summary>
        public string ContentType { get; set; }

        /// <summary>
        /// Report file extension like "html" or "pdf"
        /// </summary>
        public string FileExtension { get; set; }

        /// <summary>
        /// The header which can be used when sending to the browser client
        /// </summary>
        public string ContentDisposition { get; set; }

        public string ReportPermanentLink { get; set; }
        public string ReportId { get; set; }
        public int? NumberOfPages { get; set; }
        public string AsyncReportLocation { get; set; }

        public IDictionary<string, string> RawDictionary { get; set; }
    }
}
