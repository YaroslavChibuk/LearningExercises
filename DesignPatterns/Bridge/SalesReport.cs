public class SalesReport : Report
{
	public SalesReport(IReportFormatter formatter) : base(formatter) { }

	public override void Display()
	{
		formatter.Format("Sales Report Content");
	}
}
