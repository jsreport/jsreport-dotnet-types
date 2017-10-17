using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class ScriptsConfiguration
    {
        [DataMember(Name = "scripts_allowedModules")]
        public string AllowedModules { get; set; }
    }
}
