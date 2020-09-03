using Microsoft.VisualBasic.CompilerServices;
using System;
using System.IO;

namespace WPF_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\shelb\Downloads\Pride and Prejudice by Jane Austen.txt";

            string[] allLines = File.ReadAllLines(filePath);
            //string entireBook = File.ReadAllText(filePath);

            //Console.WriteLine(entireBook);
            Console.WriteLine(allLines);

            //for (int i = 0; i < allLines.Length; i++)
            //{
            //    if (i % 25 == 0 && i != 0)
            //    {
            //        Console.WriteLine("Press a key to continue...");
            //        Console.ReadKey();
            //    }
            //    Console.WriteLine(allLines[i]);
            //}

            //Output chapter at a time
            foreach (var line in allLines)
            {
                if (line.Contains("Chapter") == true)
                {
                    Console.ReadKey();
                }
                Console.WriteLine(line);
            }


        }
    }
}
