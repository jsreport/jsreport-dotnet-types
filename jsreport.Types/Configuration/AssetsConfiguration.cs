using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class AssetsConfiguration
    {
        [DataMember(Name = "extensions_assets_allowedFiles")]
        public string AllowedFiles { get; set; }

        [DataMember(Name = "extensions_assets_searchOnDiskIfNotFoundInStore")]
        public bool SearchOnDiskIfNotFoundInStore { get; set; }
    }
}
