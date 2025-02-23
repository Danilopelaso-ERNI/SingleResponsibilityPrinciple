namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report();
            ReportGenerator generator = new ReportGenerator();
            ReportFormatter formatter = new ReportFormatter();
            ReportFileHandler fileHandler = new ReportFileHandler();

            string content = "hello content, this is my world";
            report.Content = generator.GenerateReport(content);
            report.Content = formatter.Format(report.Content);

            string filename = "report.txt";
            fileHandler.SaveToFile(filename, report.Content);

            string loadedContent = fileHandler.LoadFromFile(filename);
            Console.WriteLine(loadedContent);

        }
    }

}