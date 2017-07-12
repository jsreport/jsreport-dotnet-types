using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class AssetsConfiguration
    {
        [DataMember(Name = "assets_allowedFiles")]
        public string AllowedFiles { get; set; }

        [DataMember(Name = "assets_searchOnDiskIfNotFoundInStore")]
        public bool SearchOnDiskIfNotFoundInStore { get; set; }
    }
}
