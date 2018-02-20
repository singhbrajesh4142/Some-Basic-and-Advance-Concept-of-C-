using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplList = new List<Employee>();

            emplList.Add(new Employee() { ID = 101, Name = "A", Salary = 5000, Experience = 5 });
            emplList.Add(new Employee() { ID = 102, Name = "B", Salary = 4000, Experience = 6 });
            emplList.Add(new Employee() { ID = 103, Name = "C", Salary = 6000, Experience = 3 });
            emplList.Add(new Employee() { ID = 104, Name = "D", Salary = 7000, Experience = 4 });
            emplList.Add(new Employee() { ID = 105, Name = "E", Salary = 3000, Experience = 5 });

            isPromatable isPromate = new isPromatable(promate);

            Employee.PramotedEmployee(emplList, isPromate);
        }

        public static bool promate(Employee emp)
        {
            if(emp.Experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public delegate bool isPromatable(Employee employee);

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void PramotedEmployee(List<Employee> employeeList, isPromatable isEligible)
        {
            foreach(Employee employee in employeeList)
            {
                if(isEligible(employee))
                {
                    Console.WriteLine(employee.Name + " Pramoted");
                }
            }
        }
    }
}
