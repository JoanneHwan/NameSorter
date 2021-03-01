using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace NameSorter
{
    /// <summary>
    ///  This class contains logic to process and export sort names to txt file
    /// </summary>
    class FileProcessor
    {

        /// <summary>
        ///  This method:
        ///     1. Read txt file input
        ///     2. Sort names
        ///     3. Write to txt file output
        /// </summary>
        public static string[] ProcessNameList(string inputFilepath, string outputFilepath)
        {
            // Read contents in input file
            IEnumerable<string> presortNames = File.ReadLines(inputFilepath);

            string[] sortedNames = SortNameList(presortNames);

            // Write contents to output file
            File.WriteAllLinesAsync(outputFilepath, sortedNames);

            return sortedNames;

        }

        /// <summary>
        ///  This method create and sorts Name objects created, then returns a String array 
        ///  of sorted names
        /// </summary>
        public static string[] SortNameList(IEnumerable<string> presortNames)
        {
            // Create Name objects and add them into a list
            List<Name> names = new List<Name>();
            foreach (string name in presortNames)
            {
                names.Add(new Name(name));
            }

            // Sort Name objects by Last Name then First Name
            IEnumerable<Name> sortedNames = names.OrderBy(name => name.LastName).ThenBy(name => name.FirstName);

            // Convert to String array for easier processing
            string[] strSortedNames = sortedNames.Select(p => p.FullName).ToArray();

            return strSortedNames;
        }

    }
}
