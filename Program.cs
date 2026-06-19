using System; 

namespace FolderMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            FileService fileService = new FileService();

            Console.Write("Fayl yo'lini kiriting (masalan, students.txt): ");
            string filePath = Console.ReadLine();

            
            if (fileService.FileExists(filePath))
            {
                fileService.ShowFileStatistics(filePath);
            }
            else
            {
                Console.WriteLine("Xatolik: Bunday fayl topilmadi");
            }

            Console.ReadKey();
        }
    }
}