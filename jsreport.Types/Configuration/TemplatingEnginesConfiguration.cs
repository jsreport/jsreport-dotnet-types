using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class TemplatingEnginesConfiguration
    {
        [DataMember(Name = "templatingEngines_allowedModules")]
        public string AllowedModules { get; set; }
    }
}
