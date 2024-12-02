using System;
using System.IO;
using System.Xml.Xsl;

namespace XMLProcessingApp
{
    public class XmlProcessor
    {
        private IXmlStrategy _strategy;

        public void SetStrategy(IXmlStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ExecuteStrategy(string filePath, string keyword, Action<string> outputAction)
        {
            _strategy?.Analyze(filePath, keyword, outputAction);
        }

        // Новий метод для трансформації XML за допомогою XSLT
        public void TransformXmlToHtml(string xmlPath, string xslPath, string outputHtmlPath)
        {
            try
            {
                // Перевірка існування файлів
                if (!File.Exists(xmlPath))
                {
                    throw new FileNotFoundException($"Файл XML не знайдено: {xmlPath}");
                }

                if (!File.Exists(xslPath))
                {
                    throw new FileNotFoundException($"Файл XSLT не знайдено: {xslPath}");
                }

                // Виконання трансформації
                XslCompiledTransform xslTransform = new XslCompiledTransform();
                xslTransform.Load(xslPath); // Завантаження XSLT

                // Збереження результату у вказаний файл HTML
                xslTransform.Transform(xmlPath, outputHtmlPath);

                Console.WriteLine($"Трансформація завершена! Файл збережено тут: {outputHtmlPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка під час трансформації: {ex.Message}");
            }
        }
    }
}
