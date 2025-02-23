namespace SingleResponsibilityPrinciple
{
    public class ReportFileHandler
    {
        public void SaveToFile(string filename, string content)
        {
            File.WriteAllText(filename, content);
        }

        public string LoadFromFile(string filename)
        {
            return File.ReadAllText(filename);
        }
    }
}