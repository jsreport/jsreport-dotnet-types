using System;
using System.Collections.Generic;
using System.Text;

namespace jsreport.Types
{
    public class ExtensionsConfiguration
    {
        public ScriptsConfiguration Scripts { get; set; }

        public ExpressConfiguration Express { get; set; }

        public BaseConfiguration Base { get; set; }

        public AuthenticationConfiguration Authentication { get; set; }

        public SampleTemplateConfiguration SampleTemplate { get; set; }

        public PhantomConfiguration Phantom { get; set; }

        public UnoconvConfiguration Unoconv { get; set; }        

        public SchedulingConfiguration Scheduling { get; set; }

        public ReportsConfiguration Reports { get; set; }
    }
}
