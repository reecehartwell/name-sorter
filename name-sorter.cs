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
            
            Data dataObj = new Data();
            // Save each line from the text file into an array using the filepath
            List<string> sortList = dataObj.ReadNames(arg[0]);


            SortList sortObj = new SortList();
            List<string> finalList = sortObj.SortedList(sortList);


            // Loop through the new list writing each entry to the console
            foreach (var line in finalList)
            {
                Console.WriteLine(line.ToString());
            }

            // Create the output file from the list of sorted names
            File.WriteAllLines("sorted-names-list.txt", sortList);
        }
    }
}