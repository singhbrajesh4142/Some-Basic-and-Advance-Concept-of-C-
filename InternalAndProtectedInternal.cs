using System;
using AssemblyOne;
using AssemblyTwo;

namespace InternalAndProtectedInternal
{
    class Program : AssemblyTwoClassI
    {
        static void Main(string[] args)
        {
            Program P = new Program();
            P.print();
        }
    }
}
