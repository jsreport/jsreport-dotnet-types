using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class TasksConfiguration
    {
        [DataMember(Name = "tasks_allowedModules")]
        public string AllowedModules { get; set; }
    }
}
