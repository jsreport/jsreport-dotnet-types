using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class ConnectionStringConfiguration
    {
        [DataMember(Name = "connectionString_name")]
        public string Name { get; set; }
    }    
}
