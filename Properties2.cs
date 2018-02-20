using System;

public class properties
{
    private int _id;
    private string _name;
    private int _passmark = 35;

    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Student id can not be negative");
            }
            this._id = value;
        }
        get
        {
            return this._id;
        }
    }
   

    public string Name
    {
        set
        {
        if (string.IsNullOrEmpty(value))
        {
            throw new Exception("Student Name can not be null");
        }
        this._name = value;
        }
        get
        {
            if (string.IsNullOrEmpty(this._name))
            {
                return "No Name";
            }
            else
            {
                return this._name;
            }
        }
    }

    public int Passmark
    {
      get
      {
        return this._passmark;
      }
    }
}

class Program
{
    public static void Main()
    {
        properties P1 = new properties();
        P1.Id = 4142;
        P1.Name = "Brajesh singh";

        Console.WriteLine("student id: {0}", P1.Id);
        Console.WriteLine("Student Name: {0}", P1.Name);
        Console.WriteLine("Passmark: {0}", P1.Passmark);
        Console.Read();
    }
}