using System;


namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        internal int ID = 101;
        protected internal string Name = "Brajesh singh";
    }

    public class AssemblyOneClassII
    {
        public void sampleMethod()
        {
            AssemblyOneClassI A1 = new AssemblyOneClassI();
            Console.WriteLine(A1.ID);
        }
    }
}
