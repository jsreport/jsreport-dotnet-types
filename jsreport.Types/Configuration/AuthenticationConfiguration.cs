namespace jsreport.Types
{
    public class AuthenticationConfiguration
    {        
        public AdminUserConfiguration Admin { get; set; }
        public AuthenticationCookieSession CookieSession { get; set; }
    }
}
