using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;

namespace CustomExceptionHandlingINcSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new UserAlreadyLogedIn("Custom Error : Exception class");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    // Custom class inherited with Exception class
    class UserAlreadyLogedIn : Exception
    {
        public UserAlreadyLogedIn() : base()
        {
        }

        public UserAlreadyLogedIn(string message) : base(message)
        {
        }

        public UserAlreadyLogedIn(string message, Exception innerException): base(message, innerException)
        {
        }

        public UserAlreadyLogedIn(SerializationInfo info, StreamingContext Context): base(info, Context)
        {
        }
    }
}
