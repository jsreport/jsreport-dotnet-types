using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class Configuration
    {
        public Configuration()
        {
            Phantom = new PhantomConfiguration();
            Tasks = new TasksConfiguration();
            Scripts = new ScriptsConfiguration();
        }

        public Configuration Authenticated(string username, string password)
        {
            Authentication = new AuthenticationConfiguration()
            {
                Admin = new AdminUserConfiguration()
                {
                    Username = username,
                    Password = password
                },
                CookieSession = new AuthenticationCookieSession()
                {
                    Secret = Guid.NewGuid().ToString()
                }
            };
            return this;
        }

        public Configuration AllowLocalFilesAccess()
        {
            Phantom.AllowLocalFilesAccess = true;
            Tasks.AllowedModules = "*";
            Scripts.AllowedModules = "*";

            return this;
        }

        public Configuration BaseUrl(string url)
        {
            Base = new BaseConfiguration() { Url = url };
            return this;
        }

        public Configuration BaseUrlAsWorkingDirectory()
        {
            Base = new BaseConfiguration() { Url = "${cwd}/" };
            return this;
        }

        public Configuration HostedOnSubpath(string subpath)
        {
            AppPath = subpath;
            return this;
        }

        public Configuration FileSystemStore()
        {
            ConnectionString = new ConnectionStringConfiguration()
            {
                Name = "fs"
            };

            return this;
        }

        public Configuration CreateSamples()
        {
            SampleTemplate = new SampleTemplateConfiguration()
            {
                CreateSamples = true
            };

            return this;
        }

        [DataMember(Name = "httpPort")]
        public int? HttpPort { get; set; }

        [DataMember(Name = "httpsPort")]
        public int? HttpsPort { get; set; }

        [DataMember(Name = "tempDirectory")]
        public string TempDirectory { get; set; }

        [DataMember(Name = "appPath")]
        public string AppPath { get; set; }

        [DataMember(Name = "license-key")]
        public string LicenseKey { get; set; }

        public SampleTemplateConfiguration SampleTemplate { get; set; }
                
        public ConnectionStringConfiguration ConnectionString { get; set; }
                
        public PhantomConfiguration Phantom { get; set; }
                
        public TasksConfiguration Tasks { get; set; }

        public BaseConfiguration Base { get; set; }

        public AuthenticationConfiguration Authentication { get; set; }      
        
        public LoggerConfiguration Logger { get; set; }

        public ScriptsConfiguration Scripts { get; set; }
    }
}
