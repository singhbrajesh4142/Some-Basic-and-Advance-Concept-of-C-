using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

    public virtual void print()
    {
        Console.WriteLine(FirstName+" " +LastName);
    }
}

public class FullTime : Employee
{
    public override void print()
    {
        Console.WriteLine(FirstName + " " + LastName + "- FullTime");
    }
}

public class PartTime : Employee
{
    public override void print()
    {
        Console.WriteLine(FirstName + " " + LastName + "- PartTime");
    }
}

public class Temporary : Employee
{
    public override void print()
    {
        Console.WriteLine(FirstName + " " + LastName + "- Temporary");
    }
}

    class Program
    {
        static void Main()
        {
            Employee[] E = new Employee[4];      //Array of Employee
           
            E[0] = new Employee();
            E[1] = new FullTime();
            E[2] = new PartTime();
            E[3] = new Temporary();
            

            foreach (Employee e in E)
            {
                e.print();
            }
            Console.Read();
        }
    }