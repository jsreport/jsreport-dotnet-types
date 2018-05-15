using System.Runtime.Serialization;

namespace jsreport.Types
{
    public enum Recipe
    {
        [EnumMember(Value = "phantom-pdf")]
        PhantomPdf,
        [EnumMember(Value = "html")]
        Html,
        [EnumMember(Value = "fop-pdf")]
        FopPdf,
        [EnumMember(Value = "text")]
        Text,
        [EnumMember(Value = "html-with-browser-client")]
        HtmlWithBrowserClient,
        [EnumMember(Value = "html-to-xlsx")]
        HtmlToXlsx,
        [EnumMember(Value = "xlsx")]
        Xlsx,
        [EnumMember(Value = "electron-pdf")]
        ElectronPdf,
        [EnumMember(Value = "html-to-text")]
        HtmlToText,
        [EnumMember(Value = "wkhtmltopdf")]
        Wkhtmltopdf,
        [EnumMember(Value = "phantom-image")]
        PhantomImage,
        [EnumMember(Value = "chrome-pdf")]
        ChromePdf
    }
}
