using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class LoggerTransportConfiguration
    {
        [DataMember(Name = "logger_file_level")]
        public string Level { get; set; }
        [DataMember(Name = "logger_file_filename")]
        public string Filename { get; set; }
        [DataMember(Name = "logger_file_transport")]
        public string Transport { get; set; }
    }
}
