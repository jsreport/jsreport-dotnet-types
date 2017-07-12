using System.Runtime.Serialization;

namespace jsreport.Types
{
    public class AuthenticationCookieSession
    {
        [DataMember(Name = "authentication_cookieSession_secret")]
        public string Secret { get; set; }
    }
}
