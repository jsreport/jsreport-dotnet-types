using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class PhantomConfiguration
    {
        [DataMember(Name = "phantom_allowLocalFilesAccess")]
        public bool AllowLocalFilesAccess { get; set; }

        [DataMember(Name = "phantom_timeout")]
        public int? Timeout { get; set; }
    }
}
