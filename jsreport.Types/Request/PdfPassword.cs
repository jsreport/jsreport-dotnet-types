using System;
using System.Collections.Generic;
using System.Text;

namespace jsreport.Types
{
    public class PdfPassword
    {
       public string Password { get; set; }  
       public string OwnerPassword { get; set; }
       public string ProtectionLevel { get; set; }
    }
}
