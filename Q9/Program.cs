using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    public class MyBaseClass
    {
        protected void ProtectedMethod()
        {
            Console.WriteLine("This is a protected method.");
        }
    }
    public class MyDerivedClass : MyBaseClass
    {
        public void AccessProtectedMethod()
        {
            Console.WriteLine("Derived class is accessing the protected method.");
            ProtectedMethod();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass derivedObject = new MyDerivedClass();
            derivedObject.AccessProtectedMethod();
        }
    }
}
