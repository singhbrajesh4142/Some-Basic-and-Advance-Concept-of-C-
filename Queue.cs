using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueINCS
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Customer Customer1 = new Customer
            {
                Id = 1,
                Name = "Customer1",
                Gender = "Male"
            };
            Customer Customer2 = new Customer
            {
                Id = 2,
                Name = "Customer2",
                Gender = "Female"
            };
            Customer Customer3 = new Customer
            {
                Id = 3,
                Name = "Customer3",
                Gender = "Male"
            };
            Customer Customer4 = new Customer
            {
                Id = 4,
                Name = "Customer4",
                Gender = "Female"
            };
            Customer Customer5 = new Customer
            {
                Id = 5,
                Name = "Customer5",
                Gender = "Male"
            };
            #endregion

            Queue<Customer> customer = new Queue<Customer>();
            customer.Enqueue(Customer1);
            customer.Enqueue(Customer2);
            customer.Enqueue(Customer3);
            customer.Enqueue(Customer4);
            customer.Enqueue(Customer5);

            Customer cust = customer.Dequeue();
            Console.WriteLine("Id = {0}, Name = {1}", cust.Id, cust.Name);

            // Retrieve Peek element without removing it
            Customer PeekCustomr = customer.Peek();
            Console.WriteLine("Id = {0}, Name = {1}", PeekCustomr.Id, PeekCustomr.Name);
            // check if item exist or not
            // Contains()


        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
