public abstract class Report
{
	protected IReportFormatter formatter;

	protected Report(IReportFormatter formatter)
	{
		this.formatter = formatter;
	}

	public abstract void Display();
}
