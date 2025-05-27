var report = new SalesReport(new PdfFormatter());
report.Display(); // PDF: Sales Report Content

var report2 = new SalesReport(new HtmlFormatter());
report2.Display(); // HTML: Sales Report Content
