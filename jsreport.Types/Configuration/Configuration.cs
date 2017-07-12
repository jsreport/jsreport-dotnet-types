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

            return this;
        }

        public Configuration BaseUrl(string url)
        {            
            return this;
        }

        public Configuration HostedOnSubpath(string subpath)
        {
            AppPath = subpath;
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
                
        public ConnectionString ConnectionString { get; set; }
                
        public PhantomConfiguration Phantom { get; set; }
                
        public TasksConfiguration Tasks { get; set; }

        public AuthenticationConfiguration Authentication { get; set; }      
        
        public LoggerConfiguration Logger { get; set; }
    }
}
