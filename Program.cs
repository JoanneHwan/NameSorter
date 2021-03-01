using System;
using System.IO;
using System.Collections.Generic;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFilepath = @"unsorted-names-list.txt";
            string outputFilepath = @"sorted-names-list.txt";

            // Read txt file input, sort names and write to txt file output
            string[] sortedNames = FileProcessor.ProcessNameList(inputFilepath, outputFilepath);

            // Print each line of returned sorted name list
            Array.ForEach(sortedNames, Console.WriteLine);
        }

    }
}
