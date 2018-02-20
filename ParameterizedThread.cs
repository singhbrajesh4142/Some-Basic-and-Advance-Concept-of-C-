using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParameterizedThreadInCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter target value");
            object target = Console.ReadLine();

            Number number = new Number();

            Thread T = new Thread(new ParameterizedThreadStart(number.PrintNumber));
            T.Start(target);
        }
    }

    public class Number
    {
        public void PrintNumber(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
