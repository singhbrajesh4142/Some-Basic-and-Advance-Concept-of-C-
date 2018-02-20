using System;


class Customer
{
    string _FirstName;
    string _LastName;

    public Customer()
        : this("no FirstName Provided", "No LastName Provided")
    {
    }


    public Customer(string FirstName, string LastName)
    {
        this._FirstName = FirstName;
        this._LastName = LastName;
    }
    public void PrintFullName()
    {
        Console.WriteLine("Full Name: {0}",this._FirstName + " " + this._LastName);
    }
    ~Customer()
    {
        //clean up code
    }
}


    class Program
    {
        static void Main()
        {
            Customer C = new Customer();
            C.PrintFullName();
            Console.Read();
        }
    }
