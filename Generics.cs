using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerincsInCS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Equal = Calculator<string>.AreEqual("Brajesh", "Brajesh");
            //bool Equal = Calculator.AreEqual<string>("Brajesh", "Brajesh");
            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
            
        }
    }

    public class Calculator
    {
        //public static bool AreEqual(object Value1,object Value2)
        //{
        //    return Value1 == Value2;
        //}

        // Use Generics
        public static bool AreEqual<T>(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }

    // We can make generic class
    public class Calculator<T>
    {

        public static bool AreEqual(T Value1, T Value2)
        {
            return Value1.Equals(Value2);
        }
    }
}
