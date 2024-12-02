using System;
using System.Linq;
using System.Xml.Linq;

namespace XMLProcessingApp
{
    public class LinqToXmlStrategy : IXmlStrategy
    {
        public void Analyze(string filePath, string keyword, Action<string> outputAction)
        {
            var document = XDocument.Load(filePath);
            var results = document.Descendants("book")
                .Where(e => e.Attributes().Any(a => a.Value.Contains(keyword)))
                .Select(e => e.ToString());
            foreach (var result in results)
            {
                outputAction(result);
            }
        }
    }
}
