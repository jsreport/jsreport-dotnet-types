using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class BlobStorageConfiguration
    {
        [DataMember(Name = "blobStorage_provider")]
        public string Provider { get; set; }
    }
}
