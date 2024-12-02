namespace XMLProcessingApp
{
    public interface IXmlStrategy
    {
        void Analyze(string filePath, string keyword, Action<string> outputAction);
    }
}
