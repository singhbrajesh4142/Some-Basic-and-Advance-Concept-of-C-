using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumerationINcSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customer = new Customer[3];

            customer[0] = new Customer
            {
                Name = "Mark",
                Gender = Gender.Male
            };

            customer[1] = new Customer
            {
                Name = "Mary",
                Gender = Gender.Female
            };

            customer[2] = new Customer
            {
                Name = "Sam",
                Gender = Gender.Unknown
            };

            foreach (Customer customers in customer)
            {
                Console.WriteLine("Name = {0} && Gender = {1}", customers.Name, getGender(customers.Gender));
            }
        }

        public static string getGender(Gender gender)
        {
            switch (gender)
            {
                case Gender.Unknown:
                    return "UnKnown";
                case Gender.Male:
                    return "Male";
                case Gender.Female:
                    return "Female";
                default:
                    return "Invalid data Detected";
            }
        }

    }

    public enum Gender
    {
        Unknown,
        Male,
        Female
    }
    // 0- Unknown
    // 1 - Male
    // 2 - Female
    class Customer
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
    }
}