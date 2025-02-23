namespace SingleResponsibilityPrinciple
{
    public class Report
    {
        public string Content { get; set; }

        public Report() {

        }

        public void GenerateReport(string content) {
            Content = content;
        }

        public void FormatReport() {
            Content = Content.ToLower();
        }
    }
}