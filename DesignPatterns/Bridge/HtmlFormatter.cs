public class HtmlFormatter : IReportFormatter
{
	public void Format(string content)
	{
		Console.WriteLine($"HTML: {content}");
	}
}
