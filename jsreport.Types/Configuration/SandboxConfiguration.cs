using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class SandboxConfiguration
    {
        [DataMember(Name = "sandbox_allowedModules")]
        public string AllowedModules { get; set; }
    }
}
