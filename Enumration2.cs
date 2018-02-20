using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreOnEnumINcSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Method
            // retrieve all the Name from Enum
            string[] Name = (string[])Enum.GetNames(typeof(Gender));
            foreach(string name in Name)
            {
                Console.WriteLine(name);
            }

            // Retrieve all the value from enum
            int[] value = (int[])Enum.GetValues(typeof(Gender));
            foreach(int val in value)
            {
                Console.WriteLine(val);
            }
            #endregion
        }
    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
}
