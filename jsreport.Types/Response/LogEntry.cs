using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace jsreport.Types
{
    public class LogEntry
    {
        public string Message { get; set; }       
        public LogEntryLevel Level { get; set; }
        public DateTime Timestamp { get; set; }

        public override string ToString()
        {
            return $"{Timestamp} {Level.ToString()} {Message}";
        }
    }
}