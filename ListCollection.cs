using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollectionINCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };
            Customer customer2 = new Customer
            {
                ID = 112,
                Name = "Mary",
                Salary = 5550
            };
            Customer customer3 = new Customer
            {
                ID = 103,
                Name = "John",
                Salary = 6500
            };

            List<Customer> cust = new List<Customer>();
            cust.Add(customer1);
            cust.Add(customer2);
            cust.Add(customer3);
            
            foreach(Customer c in cust)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
                Console.WriteLine("---------------------------------------------");
            }

            // We can not sort complex data using sort we need to implemwnt it

            cust.Sort();
            Console.WriteLine("sorted According to ID");
            foreach (Customer c in cust)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }

            SortByName sortByName = new SortByName();
            cust.Sort(sortByName);
            Console.WriteLine("sorted According to Name");
            foreach (Customer c in cust)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }

            //----using inbuilt delegate 
            Comparison<Customer> comparisonCustomer = new Comparison<Customer>(ComparisonCustomer);
            cust.Sort(comparisonCustomer);
            Console.WriteLine("sorted According to ID");
            foreach (Customer c in cust)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }

            ////Alternative for Comparison<T>
            //cust.Sort(delegate (Customer x, Customer y) { return x.ID.CompareTo(y.ID); });
            //// using lambda expression
            //cust.Sort((c1,c2)=> c1.ID.CompareTo(c2.ID));

            // See following functions:
             //TrueForAll()
             //AsReadOnly()
             //TrimExcess()
             
        }
        private static int ComparisonCustomer(Customer x, Customer y)
        {
            return x.ID.CompareTo(y.ID);
        }
    }

    public class SortByName : IComparer<Customer>
    {
        public int Compare(Customer x, Customer y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }

    public class Customer : IComparable<Customer>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

        // This implementation will sort According to ID
        public int CompareTo(Customer other)
        {
            if (this.ID > other.ID)
                return 1;
            else if (this.ID < other.ID)
                return -1;
            else
                return 0;
        }
        // This implementation will sort According to ID
        //public int CompareTo(Customer other)
        //{
        //    return this.ID.CompareTo(other.ID);
        //}
    }
}
