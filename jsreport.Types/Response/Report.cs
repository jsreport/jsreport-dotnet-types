using System.Collections.Generic;
using System.IO;

namespace jsreport.Types
{
    /// <summary>
    /// Output of jsreport rendering process
    /// </summary>
    public class Report
    {
        /// <summary>
        /// Stream with report
        /// </summary>
        public Stream Content { get; set; }

        public ReportMeta Meta { get; set; }
    }
}