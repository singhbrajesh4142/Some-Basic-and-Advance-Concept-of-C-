using System;
using System.Reflection;

namespace LateBindingUsingReflectionINcSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Late Binding
                Assembly executingAssembly = Assembly.GetExecutingAssembly();
                Type customerType = executingAssembly.GetType("LateBindingUsingReflectionINcSharp.Customer");
                object customerInstance = Activator.CreateInstance(customerType);

                MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

                string[] methodParameter = new string[2];
                methodParameter[0] = "Late";
                methodParameter[1] = "Binding";

                string fullName = (string)getFullNameMethod.Invoke(customerInstance, methodParameter);
                Console.WriteLine(fullName);
            }catch(Exception e)
            {
                Console.WriteLine("An Error has occured!");
                Console.WriteLine("Error Message : " + e.Message);
            }

            //// Early Binding
            //Customer C1 = new Customer();
            //string fullName = C1.GetFullName("Brajesh", "Singh");
            //Console.WriteLine(fullName);
        }
    }

    public class Customer
    {
        public string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }
    }
}
