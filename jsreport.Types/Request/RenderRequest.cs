namespace jsreport.Types
{
    public class RenderRequest
    {
        public RenderRequest()
        {
            Template = new Template();
            Options = new RenderOptions();
        }

        public Template Template { get; set; }
        public object Data { get; set; }
        public RenderOptions Options { get; set; }

        public object Overwrites { get; set; }
    }
}
