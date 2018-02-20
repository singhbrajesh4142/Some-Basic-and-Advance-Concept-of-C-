using System;
using System.Reflection;

namespace ReflectionINcSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type T = Type.GetType("ReflectionINcSharp.Customer");
            Console.WriteLine("Full Name = {0}",T.FullName);
            Console.WriteLine("Just Name = {0}", T.Name);
            Console.WriteLine("Just Namespace = {0}", T.Namespace);
            Console.WriteLine();

            Console.WriteLine("Properties of Customer class");
            PropertyInfo[] Properties = T.GetProperties();
            foreach(PropertyInfo property in Properties)
            {
                Console.WriteLine(property.PropertyType.Name + " " + property.Name);
            }

            Console.WriteLine();
            Console.WriteLine("Methods of Customer class");
            MethodInfo[] Methods = T.GetMethods();
            foreach (MethodInfo method in Methods)
            {
                Console.WriteLine(method.ReturnType.Name + " " + method.Name);
            }

        }
    }

    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }

        public Customer(int ID, string Name)
        {
            this.id = ID;
            this.Name = Name;
        }

        public Customer()
        {
            this.id = -1;
            this.Name = string.Empty;
        }

        public void printID()
        {
            Console.WriteLine(this.id);
        }

        public void printName()
        {
            Console.WriteLine(this.Name);
        }
    }
}
