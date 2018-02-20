using System;
using System.Threading;
using System.Diagnostics;

namespace ProtectedSharedResourcesInCS
{

    class Program
    {
        static int total = 0;
        static object _lock = new object();

        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            Thread T1 = new Thread(PrintNumber);
            Thread T2 = new Thread(PrintNumber);
            Thread T3 = new Thread(PrintNumber);
            T1.Start();
            T2.Start();
            T3.Start();

            T1.Join();
            T2.Join();
            T3.Join();

            stopwatch.Stop();
            Console.WriteLine("total time elapsed : {0}", stopwatch.ElapsedTicks);
            Console.WriteLine("Total is  : {0}", total);
        }
        // Reference Locking 
        //static void PrintNumber()
        //{
        //    for (int i = 1; i <= 1000000 ; i++)
        //    {
        //        Interlocked.Increment(ref total);
        //    }
        //}
        // Another Way : Locking 
        static void PrintNumber()
        {
            for (int i = 1; i <= 1000000; i++)
            {
                lock (_lock)
                {
                    total++;
                }
            }
        }
    }
}
