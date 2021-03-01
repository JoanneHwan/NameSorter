using System;
using System.Collections.Generic;
using System.Text;

namespace NameSorter
{
    /// <summary>
    ///  This class initiates the variables required to sort names based on each line of file input
    /// </summary>
    class Name
    {
        public string LastName;
        public string FirstName;
        public string FullName;

        public Name(string name)
        {
            this.FullName = name;
            this.RenderName(name);
        }

        /// <summary>
        ///  This method splits the First and Last Name based on name given from file input
        /// </summary>
        private void RenderName(string name)
        {
            // Split name into different parts
            string[] nameParts = name.Split(' ');
            int numOfParts = nameParts.Length;

            // Last part of the name is always the Last Name
            this.LastName = nameParts[numOfParts - 1];

            // Removed Last Name and reconstruct the First Name
            Array.Resize(ref nameParts, numOfParts - 1);
            this.FirstName = String.Join(" ", nameParts);
        }
    }
}
