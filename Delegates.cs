using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    // Declaration of delegates 
    public delegate void DelegatesHello(String Message);


    class Program
    {

       
        public static void Main(string[] args)
        {
            DelegatesHello d = new DelegatesHello(Hello);
            d("How are you");
        }

        public static void Hello(String strMessage)
        {
            Console.WriteLine(strMessage);
        }

    }
}
