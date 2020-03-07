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
            Extensions = new ExtensionsConfiguration();                  
        }

        public Configuration Authenticated(string username, string password)
        {
            Extensions.Authentication = new AuthenticationConfiguration()
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

        public Configuration AllowedLocalFilesAccess()
        {
            AllowLocalFilesAccess = true;
            return this;
        }

        public Configuration BaseUrl(string url)
        {
            Extensions.Base = new BaseConfiguration() { Url = url };
            return this;
        }

        public Configuration BaseUrlAsWorkingDirectory()
        {
            Extensions.Base = new BaseConfiguration() { Url = "${cwd}/" };
            return this;
        }

        public Configuration HostedOnSubpath(string subpath)
        {
            AppPath = subpath;
            return this;
        }

        public Configuration FileSystemStore()
        {
            Store = new StoreConfiguration()
            {
                Provider = "fs"
            };

            return this;
        }

        public Configuration CreateSamples()
        {
            Extensions.SampleTemplate = new SampleTemplateConfiguration()
            {
                CreateSamples = true
            };

            return this;
        }
        
        public ExtensionsConfiguration Extensions { get; set; }

        [DataMember(Name = "allowLocalFilesAccess")]
        public bool AllowLocalFilesAccess { get; set; }        

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

        [DataMember(Name = "discover")]
        public bool? Discover { get; set; }

        [DataMember(Name = "reportTimeout")]
        public int? ReportTimeout { get; set; }

        [DataMember(Name = "enableRequestReportTimeout")]
        public bool? EnableRequestReportTimeout { get; set; }

        public ChromeConfiguration Chrome { get; set; }

        public StoreConfiguration Store { get; set; }       
                
        public TemplatingEnginesConfiguration TemplatingEngines { get; set; }   
        
        public LoggerConfiguration Logger { get; set; }

        public LoggerConfiguration EncryptionConfiguration { get; set; }        
    }
}
