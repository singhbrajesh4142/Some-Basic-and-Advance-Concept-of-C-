using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    public delegate void sampleDelegate();
    public delegate int sampleDelegateINT();
    public delegate void sampleDelegateOUT(out int param);
    class Program
    {
        static void Main(string[] args)
        {
            //// mulitcast delegates
            //sampleDelegate del1, del2, del3, del4;

            //del1 = new sampleDelegate(sampleMethodOne);
            //del2 = new sampleDelegate(sampleMethodTwo);
            //del3 = new sampleDelegate(sampleMethodThree);
            //// multicast delegate
            //del4 = del1 + del2 + del3;
            //del4();

            sampleDelegate del = new sampleDelegate(sampleMethodOne);   // register sampleMethodOne to delegate
            del += sampleMethodTwo;                                     // register sampleMethodTwo to delegate
            del += sampleMethodThree;                                   // register sampleMethodThree to delegate
            del -= sampleMethodThree;                                   // un-register sampleMethodThree to delegate
            del();

            sampleDelegateINT delINT = new sampleDelegateINT(sampleMethodOneINT);
            delINT += sampleMethodTwoINT;
            Console.WriteLine("Returned Value {0}", delINT());

            sampleDelegateOUT delOUT = new sampleDelegateOUT(sampleMethod1);
            delOUT += sampleMethod2;
            int param;
            delOUT(out param);
            Console.WriteLine("Output Parameter Value : {0}", param);
            Console.ReadLine();
                
        }

        public static void sampleMethodOne()
        {
            Console.WriteLine("sampleMethodOne invoked");
        }
        public static void sampleMethodTwo()
        {
            Console.WriteLine("sampleMethodTwo invoked");
        }
        public static void sampleMethodThree()
        {
            Console.WriteLine("sampleMethodThree invoked");
        }

        // example with return value
        public static int sampleMethodOneINT()
        {
            return 1;
        }
        public static int sampleMethodTwoINT()
        {
            return 2;
        }


        // example for output parameter
        public static void sampleMethod1(out int Number)
        {
            Number = 1;
        }
        public static void sampleMethod2(out int Number)
        {
            Number = 2;
        }
    }
}
