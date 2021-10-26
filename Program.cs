using System;
using System.IO;

namespace name_sorter
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Create a string variable and get user input from the keyboard and store it in the variable
            string filePath = Console.ReadLine();
            //string filePath = args;

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("File Path is: " + filePath);

            // To save each line seperately in an array use 'ReadAllLines()'
            //D:\Development\C#\name-sorter\name-sorter\unsorted-names-list.txt
            //string[] lines = System.IO.File.ReadAllLines(filePath);
            string[] lines = System.IO.File.ReadAllLines(args[0]);

            foreach (string line in lines)
            {
                Console.WriteLine(line.ToString());
            }
        }
    }
}