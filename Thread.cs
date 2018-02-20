using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadInCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread numberThread = new Thread(Number.PrintNumber);
            numberThread.Start();

            //// Use ThreadStart delegate
            //Thread numberThread = new Thread(new ThreadStart(Number.PrintNumber()));
            //numberThread.Start();

            // Use lambda Expression
            Thread T1 = new Thread(()=>Number.PrintNumber());
            T1.Start();
        }
    }

    public class Number
    {
        public static void PrintNumber()
        {
            for(int i=1; i<=10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
