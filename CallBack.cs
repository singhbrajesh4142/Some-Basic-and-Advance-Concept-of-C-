using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ParameterizedThreadInCS
{
    public delegate void SumOfNumbersCallback(int SumOfNumbers);

    class Program
    {
        public static void PrintSum(int sum)
        {
            Console.WriteLine("Sum is : {0}", sum);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter target value");
            int target = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersCallback callback = new SumOfNumbersCallback(PrintSum);

            Number number = new Number(target,callback);
            Thread T = new Thread(new ThreadStart(number.PrintSumOfNumber));
            T.Start();
        }
    }

    public class Number
    {
        int _target;
        SumOfNumbersCallback _CallBackMethod;

        public Number(int target, SumOfNumbersCallback CallBackMethod)
        {
            this._target = target;
            this._CallBackMethod = CallBackMethod;
        }
        public void PrintSumOfNumber()
        {
            int sum = 0;
            for (int i = 1; i <= _target; i++)
            {
                sum += i;
            }
            if (_CallBackMethod != null) { 
                _CallBackMethod(sum);
                }
            
        }
    }
}
