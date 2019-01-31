using System;
using System.IO;

namespace RandomReaderAndWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the file path for the file desired to be read?");
            string location = Console.ReadLine();



            StreamReader reader;
            reader = new StreamReader(@location);
            while(reader.EndOfStream == false)
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }
            reader.Close();
            Console.WriteLine("Press Enter to Exit.");
            Console.ReadLine();
        }
    }
}
