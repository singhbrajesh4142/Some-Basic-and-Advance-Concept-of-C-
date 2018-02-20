using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadJoinAndThreadIsAliveInCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Started");
            Thread T1 = new Thread(new ThreadStart(Thread1Method));
            T1.Start();

            Thread T2 = new Thread(new ThreadStart(Thread2Method));
            T2.Start();

            

            if (T1.IsAlive)
            {
                for(int i=0; i<=10; i++)
                {
                    Console.WriteLine("Thread 1 still doing it's work");
                    Thread.Sleep(500);
                }
                
            }
            else
            {
                Console.WriteLine("Thread 1 Completed");
            }
            T1.Join(1000);
            Console.WriteLine("Thread 1 Completed");

            T2.Join();
            Console.WriteLine("Thread 2 Completed");

            Console.WriteLine("Main Completed");
        }

        public static void Thread1Method()
        {
            Console.WriteLine("Thread 1 Method Started !");
            Thread.Sleep(5000);
        }
        public static void Thread2Method()
        {
            Console.WriteLine("Thread 2 Method Started !");
        }

    }
}
