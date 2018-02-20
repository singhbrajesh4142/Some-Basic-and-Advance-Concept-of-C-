using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersINCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine("Name of Employee With Id 2: " + company[2]);
            Console.WriteLine("Name of Employee With Id 3: " + company[3]);
            Console.WriteLine("Name of Employee With Id 6: " + company[6]);

            company[2] = "Name of 2 Changed";
            company[3] = "Name of 3 Changed";
            company[6] = "Name of 6 Changed";

            Console.WriteLine("Name of Employee With Id 2: " + company[2]);
            Console.WriteLine("Name of Employee With Id 3: " + company[3]);
            Console.WriteLine("Name of Employee With Id 6: " + company[6]);

            Console.WriteLine("total male Employee: " + company["Male"]);
        }
    }
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }

    public class Company
    {
        private List<Employee>  employeeList ;
        public Company()
        {
            employeeList = new List<Employee>();
            employeeList.Add(new Employee { EmployeeID = 1, Name = "Mark", Gender = "Male" });
            employeeList.Add(new Employee { EmployeeID = 2, Name = "Mary", Gender = "FeMale" });
            employeeList.Add(new Employee { EmployeeID = 3, Name = "Jon", Gender = "Male" });
            employeeList.Add(new Employee { EmployeeID = 4, Name = "Dig", Gender = "Male" });
            employeeList.Add(new Employee { EmployeeID = 5, Name = "Decap", Gender = "Male" });
            employeeList.Add(new Employee { EmployeeID = 6, Name = "Scott", Gender = "Male" });
            employeeList.Add(new Employee { EmployeeID = 7, Name = "Todd", Gender = "Male" });
            employeeList.Add(new Employee { EmployeeID = 8, Name = "Ben", Gender = "Male" });
        }
        // creating indexers
        public string this[int employeeID]
        {
            get
            {
                return employeeList.FirstOrDefault(emp => emp.EmployeeID == employeeID).Name;
            }
            set
            {
                employeeList.FirstOrDefault(emp => emp.EmployeeID == employeeID).Name = value;
            }
        }
        public int this[string gender]
        {
            get
            {
                return employeeList.Count(emp => emp.Gender == gender);
            }
            set
            {
               
            }
        }

    }
}
