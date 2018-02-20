using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceImplementationInCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of Processor: {0} ", Environment.ProcessorCount);
            Console.WriteLine(Environment.CommandLine);
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine(Environment.HasShutdownStarted);
            Console.WriteLine(Environment.Is64BitOperatingSystem);
            Console.WriteLine(Environment.Is64BitProcess);
            Console.WriteLine(Environment.MachineName);
            Console.WriteLine(Environment.OSVersion);
            Console.WriteLine(Environment.SystemPageSize);
            Console.WriteLine(Environment.UserName);
            Console.WriteLine(Environment.Version);
            Console.WriteLine(Environment.WorkingSet);
            Console.WriteLine(Environment.UserDomainName);
           
        }
    }
}
