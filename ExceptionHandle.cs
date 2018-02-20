using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ExceptionHandlingINcSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                StreamReader streamReader = new StreamReader(@"C:\Users\Brajesh singh\Documents\CSS3\Countries.xml");
                Console.Write(streamReader.ReadToEnd());
                streamReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Source:" + e.Source);
                Console.WriteLine("InnerException: " + e.InnerException);
                Console.WriteLine("StackTrace : " + e.StackTrace);
                Console.WriteLine("Message: " + e.Message);
            }

            Console.WriteLine();

            try
            {
                try
                {
                    Console.WriteLine("Enter First Number");
                    int FN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;
                    Console.WriteLine("Result : {0} ", Result);
                }
                catch (Exception e)
                {
                    string filePath = @"C:\Users\Brajesh singh\Documents\CSS3\Log.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(e.GetType());
                        sw.WriteLine();
                        sw.Write(e.Message);
                        sw.Close();

                        Console.WriteLine("There is an error, Please try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present", e);
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Current Exception: {0}", ex.GetType().Name);
                if (ex.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: {0}", ex.InnerException.GetType().Name);
                }
            }
        }
    }
}
