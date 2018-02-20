using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryINCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };
            Customer customer2 = new Customer()
            {
                ID = 110,
                Name = "pon",
                Salary = 5600
            };
            Customer customer3 = new Customer()
            {
                ID = 119,
                Name = "John",
                Salary = 6000
            };

            Dictionary<int, Customer> dictionaryCustomer = new Dictionary<int, Customer>();
            dictionaryCustomer.Add(customer1.ID, customer1);
            dictionaryCustomer.Add(customer2.ID, customer2);
            dictionaryCustomer.Add(customer3.ID, customer3);

            //Customer customer119 =  dictionaryCustomer[119];
            //Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", customer119.ID, customer119.Name, customer119.Salary);

            // we can retrieve the value in this way also
            foreach(KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomer)
            {
                Console.WriteLine("Key = {0}", customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("Id = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
                Console.WriteLine("------------------------------------");
            }
            // Try following functions: 
            // TryGetValue()
            // Count()
            // Remove
            // Clear()

        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
