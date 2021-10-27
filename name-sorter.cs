using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace name_sorter
{
    internal class Program
    {

        static void Main(string[] args)
        {

            // Set file path using value entered into the command line
            String filePath = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\" + args[0]);

            // Print the filepath
            Console.WriteLine("File Path is: " + filePath);

            // Save each line from the text file into an array using the filepath
            string[] lines = System.IO.File.ReadAllLines(filePath);

            // Create List to be used for sorting
            List<string> sortList = new List<string>();

            // Loop through array adding each entry to the list
            foreach (string line in lines)
            {
                //Console.WriteLine(line.ToString());
                sortList.Add(line);
            }

            // Sort the list by surname then first name
            sortList = sortList.OrderBy(x => x.Substring(x.LastIndexOf(' ') + 1) + x).ToList();

            // Loop through the new list writing each entry to the console
            foreach (var line in sortList)
            {
                Console.WriteLine(line.ToString());
            }

            // Create the output file from the list of sorted names
            File.WriteAllLines("sorted-names-list.txt", sortList);
        }
    }
}