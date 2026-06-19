using System;
using System.IO;

namespace FolderMap
{
    public class FileService
    {
        public bool FileExists(string filePath)
        {
            return File.Exists(filePath); 
        }

        public void ShowFileStatistics(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath); 

            long fileSize = fileInfo.Length; 
            DateTime lastModified = fileInfo.LastWriteTime;

            int lineCount = 0;
            int wordCount = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null) 
                {
                    lineCount++;

                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        
                        string[] words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        wordCount += words.Length; 
                    }
                }
            }

            Console.WriteLine($"\nFayl: {fileInfo.Name}");
            Console.WriteLine($"Xajmi: {fileSize} bayt");
            Console.WriteLine($"Qatori: {lineCount}");
            Console.WriteLine($"So'zlari: {wordCount}");
            Console.WriteLine($"Oxirgi o'zgartirilgan sana: {lastModified:dd.MM.yyyy}");
        }
    }
}