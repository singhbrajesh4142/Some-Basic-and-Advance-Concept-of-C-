using System;
using AssemblyOne;

namespace AssemblyTwo
{
    public class AssemblyTwoClassI : AssemblyOneClassI
    {
        public void print()
        {
            AssemblyOneClassII A1 = new AssemblyOneClassII();
            A1.sampleMethod();
            Console.WriteLine("This is from Assembly Two");

            AssemblyTwoClassI A2 = new AssemblyTwoClassI();
            Console.WriteLine(A2.Name);
        }
    }
    public class AssemblyTwoClassII
    {

    }
}
