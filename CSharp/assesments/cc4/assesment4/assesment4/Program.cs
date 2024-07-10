using System;
using System.IO;

class Program
{
    static void Main()
    {
        string directoryPath = @" C:\ass4text";
        string fileName = "ass4txt.txt";
        string filePath = Path.Combine(directoryPath, fileName);
        string textToAppend = "hello, Welcome to C sharp Training in Infinite ";

        try
        {
            
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(textToAppend);
            }

            Console.WriteLine("yeah..!! your text appended successfully on your asstxt4 file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}