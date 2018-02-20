using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface1
{
    interface I1
    {
        // public by default
        void InterfaceMethod();
    }
    
    interface I2
    {
        void InterfaceMethod();
    }

    class Program : I1, I2
    {
        // Access modifiers are not allowed in explicitly interface
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }

        static void Main(string[] args)
        {
            Program P = new Interface1.Program();
            ((I1)P).InterfaceMethod();
            ((I2)P).InterfaceMethod();
            // I1 i1 = new Program();
            // i1.InterfaceMethod();
        }
    }
}
