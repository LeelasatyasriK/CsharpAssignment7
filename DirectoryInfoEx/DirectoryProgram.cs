using System;
using System.IO;
namespace DirectoryClassEx
{
    class DirectoryProgram
    {
        static void Main(string[] args)
        {

            //try
            //{
            //    DirectoryInfo directory = new DirectoryInfo(@"C:\Users\KOSATYAS\Desktop\DirectoryInfo");
            //    directory.Create();
            //    Console.WriteLine("The directory is created successfully.");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Directory not created: {0}", e.ToString());
            //}
            string directoryPath = @"C:\Users\KOSATYAS\Desktop\DirectoryInfo";
            try
            {
                string[] filePaths = Directory.GetFiles(directoryPath, "*.txt");
                foreach (string filePath in filePaths)
                {
                    string fileContents = File.ReadAllText(filePath);
                    Console.WriteLine("Contents of{0}:", filePath);
                    Console.WriteLine(fileContents);
                    Console.WriteLine();
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("DirectoryNotFound:{0}", directoryPath);
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occured:{0}", ex.Message);
            }
            Console.ReadLine();
        }
    }
}
