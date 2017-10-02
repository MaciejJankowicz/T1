using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ścieżkę do pliku");
            string toRead = Console.ReadLine();

            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(toRead))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    Console.WriteLine("File opened");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            SymbolReader SR = new SymbolReader(toRead);
        }
    }
}
