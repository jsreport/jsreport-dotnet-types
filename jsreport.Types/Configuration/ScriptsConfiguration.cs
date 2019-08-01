using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class ScriptsConfiguration
    {
        [DataMember(Name = "extensions_scripts_allowedModules")]
        public string AllowedModules { get; set; }

        [DataMember(Name = "extensions_scripts_timeout")]
        public int? Timeout { get; set; }
    }
}
