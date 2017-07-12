using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class ConnectionString
    {
        [DataMember(Name = "connectionString_name")]
        public string Name { get; set; }
    }    
}
