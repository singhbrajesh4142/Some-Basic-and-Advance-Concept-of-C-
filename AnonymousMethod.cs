using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodInCS
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Employee {ID = 101, Name = "mark" },
                new Employee {ID = 102, Name = "John" },
                new Employee {ID = 103, Name = "Mary" }
            };

            // Step-2
            //Predicate<Employee> employeePridicate = new Predicate<Employee>(FindEmployee);

            // Step-3 
            //Employee employee = employeeList.Find(emp => employeePridicate(emp));
            Employee employee = employeeList.Find(
                delegate(Employee emp)
                {
                    return emp.ID == 102;
                }
                );
            Console.WriteLine("Id = {0}, Name = {1}", employee.ID, employee.Name);
        }

        // Step-1
        //public static bool FindEmployee(Employee emp)
        //{
        //    return emp.ID == 102;
        //}
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
