namespace SingleResponsibilityPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report();
            report.GenerateReport("This is a content");
            report.FormatReport();

            ReportFileHandler fileHandler = new ReportFileHandler();
            string filename = "report.txt";

            fileHandler.SaveToFile(filename, report.Content);

            string loadedContent = fileHandler.LoadFromFile(filename);
            Console.WriteLine(loadedContent);

        }
    }

}