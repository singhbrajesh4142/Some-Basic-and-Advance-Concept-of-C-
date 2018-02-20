using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingAbuseSolved
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                Console.WriteLine("Enter Numerator");
                int Numerator;
                bool IsNumeratorConversionSuccessfull = Int32.TryParse(Console.ReadLine(), out Numerator);

                if (IsNumeratorConversionSuccessfull)
                {
                    Console.WriteLine("Enter Denominator");
                    int Denominator;
                    bool IsDenominatorConversionSuccessfull = Int32.TryParse(Console.ReadLine(), out Denominator);

                    if (IsDenominatorConversionSuccessfull && Denominator != 0)
                    {
                        int Result = Numerator / Denominator;
                        Console.WriteLine("Result : {0} ", Result);
                    }
                    else
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine("Denominator should not be Zero");
                        }
                        else
                        {
                            Console.WriteLine("Denominator should be a valid integer with in a range from {0} to {1}", Int32.MinValue, Int32.MaxValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Numerator should be a valid integer with in a range from {0} to {1}", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
