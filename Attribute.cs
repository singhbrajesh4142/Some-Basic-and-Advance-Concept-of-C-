using System;
using System.Collections.Generic;

namespace AttributesINcSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculator.Add(10, 20));
            Console.WriteLine(Calculator.Add(new List<int>(){ 10, 30, 40}));
        }
    }

    class  Calculator
    {
        // Attributes llowed us to add some declarative information on our program
        [ObsoleteAttribute("Use Add(List<int> Numbers) Method", false)]
        public static int Add(int FN, int SN)
        {
            return FN + SN;
        }

        public static int Add(List<int> Numbers)
        {
            int Sum = 0;
            foreach(int number in Numbers)
            {
                Sum += number;
            }
            return Sum;
        }
    }
}
