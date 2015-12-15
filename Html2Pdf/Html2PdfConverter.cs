using TuesPechkin;

namespace Html2Pdf
{
    public static class Html2PdfConverter
    {
        private static IConverter converter = new ThreadSafeConverter(new RemotingToolset<PdfToolset>(new Win32EmbeddedDeployment(new TempFolderDeployment())));

        public static byte[] ConvertHtml2PDF(string htmlContent)
        {
            return converter.Convert(new TuesPechkin.HtmlToPdfDocument(htmlContent));
        }
    }
}
