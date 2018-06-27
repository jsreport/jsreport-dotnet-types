using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class AdminUserConfiguration
    {
        public AdminUserConfiguration()
        {
        }

        [DataMember(Name = "extensions_authentication_admin_username")]
        public string Username { get; set; }

        [DataMember(Name = "extensions_authentication_admin_password")]
        public string Password { get; set; }
    }
}
