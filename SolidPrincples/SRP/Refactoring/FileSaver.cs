using BestPractices.SolidPrinciples.Refactoring.Contracts;
using System.IO;

namespace BestPractices.SolidPrinciples.Refactoring
{
    internal class FileSaver
    {
        public void SaveToFile<T>(string directoryPath, string fileName, IEntryManager<T> report)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            File.WriteAllText(Path.Combine(directoryPath, fileName), report.ToString());
        }
    }
}
