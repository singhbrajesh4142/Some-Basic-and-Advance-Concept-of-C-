using System;

public class properties
{
    private int _id;
    private string _name;
    private int _passmark = 35;

    public void SetId(int Id)
    {
        if(Id <= 0)
        {
            throw new Exception("Student id can not be negative");
        }
        this._id = Id ;
    }
    public int GetId()
    {
        return this._id;
    }

    public void SetName(string Name)
    {
        if (string.IsNullOrEmpty(Name))
        {
            throw new Exception("Student Name can not be null");
        }
        this._name = Name;
    }
    public string GetName()
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

    public int GetPassmark()
    {
        return this._passmark;
    }
}

class Program
{
     public static void Main( )
     {
         properties P1 = new properties();
         P1.SetId(4142);
         P1.SetName("Brajesh singh");

         Console.WriteLine("student id: {0}", P1.GetId());
         Console.WriteLine("Student Name: {0}", P1.GetName());
         Console.WriteLine("Passmark: {0}", P1.GetPassmark());
         Console.Read();
     }
}