public class PdfFormatter : IReportFormatter
{
	public void Format(string content)
	{
		Console.WriteLine($"PDF: {content}");
	}
}
