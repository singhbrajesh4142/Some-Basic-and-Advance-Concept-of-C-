using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace OptionalParametersINCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddNumbers(10,20,30,30,40));

            int[] parameter = new int[] { 30, 30 , 50};
            Console.WriteLine(AddNumber(10, 20,parameter));

            Console.WriteLine(AddNum(10, 20, new int[] { 30, 40 }));

            // pass 2 as an argument for third parameter
            Test(1, c: 2);

            Console.WriteLine(AddNumbersUsingOptional(10, 20, new int[] {30, 40 }));
        }

        // There are many ways to make optional parameters
        // Method 1 parameter object array
        public static int AddNumbers(int FirstNumber, int secondNumber, params object[] RestOftheParameter)
        {
            int result = FirstNumber + secondNumber;
            if(RestOftheParameter != null)
            {
                foreach(int i in RestOftheParameter)
                {
                    result += i;
                }
            }
            return result;
        }
        // Method 2 : Method overloading
        public static int AddNumber(int FN, int SN)
        {
            return FN + SN;
        }
        public static int AddNumber(int FN, int SN, int[] parameter)
        {
            int result = FN + SN;
            if(parameter != null)
            {
                foreach(int i in parameter)
                {
                    result += i;
                }
            }
            return result;
        }
        // Method 3:  Specify parameter Defaults
        public static int AddNum(int FN, int SN, int[] parameter = null)
        {
            int result = FN + SN;
            if (parameter != null)
            {
                foreach (int i in parameter)
                {
                    result += i;
                }
            }
            return result;
        }
        // Method 4:  using Optinal Attribute
        public static int AddNumbersUsingOptional(int FN, int SN,[Optional] int[] parameter)
        {
            int result = FN + SN;
            if (parameter != null)
            {
                foreach (int i in parameter)
                {
                    result += i;
                }
            }
            return result;
        }

        //Extra 
        public static void Test(int a, int b = 10, int c = 20)
        {
            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);
            Console.WriteLine("c= " + c);
        }

    }  
}
