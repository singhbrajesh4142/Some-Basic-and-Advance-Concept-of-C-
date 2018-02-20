using System;
using System.Threading;

namespace DifferenceBetweenMonitorAndLockingInCS
{
    class Program
    {

        static int total = 0;
        static object _lock = new object();
        static void Main(string[] args)
        {
            Thread T1 = new Thread(PrintNumber);
            Thread T2 = new Thread(PrintNumber);
            Thread T3 = new Thread(PrintNumber);

            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();
            T2.Join();
            T3.Join();

            Console.WriteLine("Total is : {0} ", total);
        }

        static void PrintNumber()
        {
            for(int i =1; i <= 100000; i++)
            {

                //lock (_lock)
                //{
                //    total++;
                //}

                // Replace this lock block with Monitor 
                //Monitor.Enter(_lock);
                //try
                //{
                //    total++;
                //}
                //finally
                //{
                //    Monitor.Exit(_lock);
                //}
                // We have Another overloaded version
                bool lockToken = false;
                Monitor.Enter(_lock, ref lockToken);
                try
                {
                    total++;
                }
                finally
                {
                    if (lockToken)
                        Monitor.Exit(_lock);
                }
            }
        }
    }
}
