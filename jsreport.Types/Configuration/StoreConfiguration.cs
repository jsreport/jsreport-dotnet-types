using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class StoreConfiguration
    {
        [DataMember(Name = "store_provider")]
        public string Provider { get; set; }
    }    
}
