using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace jsreport.Types
{
    public class LicenseConfiguration
    {
        [DataMember(Name = "license_licenseKey")]
        public string LicenseKey { get; set; }

        [DataMember(Name = "license_useSavedLicenseInfo")]
        public bool? UseSavedLicenseInfo { get; set; }

        [DataMember(Name = "license_licenseInfoPath")]
        public string LicenseInfoPath { get; set; }

        [DataMember(Name = "license_development")]
        public bool? Development { get; set; }
    }
}
