using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Employee
{
    public string FirstName = "FN";
    public string LastName = "LN";

    public void printFullName()
    {
        Console.WriteLine(FirstName + " " + LastName);
        Console.WriteLine("This is from Base Class");
    }
}

public class partTimeEmployee : Employee
{
    public new void printFullName()
    {
        Console.WriteLine(FirstName +" "+ LastName);
        Console.WriteLine("This is from PartTimeEmployee Class");
    }
}

public class FullTimeEmployee : Employee
{
    public new void printFullName()
    {
        Console.WriteLine(FirstName +" "+ LastName);
        Console.WriteLine("This is from FullTimeEmployee Class");
    }
}

    class Program
    {
        static void Main()
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            ((Employee)FTE).printFullName();             //Type Casting
            partTimeEmployee PTE = new partTimeEmployee();
            PTE.printFullName();
            Console.Read();
        }
    }