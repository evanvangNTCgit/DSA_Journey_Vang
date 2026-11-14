using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeVang
{
    /*
     * Not a leet code question.
     * But is code for me to go through words in a .txt file
     * And only get the 5 letter words.
     */
    public static class TextFileParserTo5Letters
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Path to .txt file to read?");
            var pathToFile = Console.ReadLine();

            Console.WriteLine("file name for completed .txt file. Will go on desktop.");
            var fileName = Console.ReadLine();
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            StreamReader sr = new StreamReader(pathToFile);
            string line = sr.ReadLine();
            List<string> words = new List<string>();
            while(line is not null)
            {                
                if(line.Length == 5)
                {
                    words.Add(line);
                }

                Console.WriteLine(line);
                line = sr.ReadLine();
            }

            string path = Path.Combine(desktop, fileName + ".txt");
            File.AppendAllLines(path, words);

            Console.WriteLine("Completed!");
            Console.ReadLine();
        }
    }
}
