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
            int target = Convert.ToInt32(Console.ReadLine());

            Number number = new Number(target);

            Thread T = new Thread(new ThreadStart(number.PrintNumber));
            T.Start();
        }
    }

    public class Number
    {
        int _target;
        public Number(int target)
        {
            this._target = target;
        }
        public void PrintNumber()
        {
                for (int i = 1; i <= _target; i++)
                {
                    Console.WriteLine(i);
                }
        }
    }
}
