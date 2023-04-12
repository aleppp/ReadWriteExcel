using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Open the text file using a stream reader.
            using (StreamReader sr = new StreamReader("example.txt"))
            {
                // Read the entire file and store its contents in a string.
                string fileContents = sr.ReadToEnd();

                // Display the file contents to the console.
                Console.WriteLine(fileContents);
            }
        }
        catch (Exception e)
        {
            // If an error occurs, display it to the console.
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
    }
}
