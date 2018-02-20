using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderINcS
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder userString = new StringBuilder("B");
            userString.Append("r");
            userString.Append("a");
            userString.Append("j");
            userString.Append("e");
            userString.Append("s");
            userString.Append("h");

            Console.WriteLine(userString);
        }
    }
}
