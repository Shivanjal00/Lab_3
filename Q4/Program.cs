using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    public class MyBaseClass
    {
        protected int protectedField;
        protected string protectedProperty { get; set; }

        protected void ProtectedMethod()
        {
            Console.WriteLine("This is a protected method.");
        }
    }

    public class MyDerivedClass : MyBaseClass
    {
        public void AccessProtectedMembers()
        {
            protectedField = 13;
            protectedProperty = "Hello, World!";
            ProtectedMethod();

            Console.WriteLine("Derived class accessed protectedField: "+protectedField);
            Console.WriteLine("Derived class accessed protectedProperty: "+protectedProperty);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass derivedObject = new MyDerivedClass();
            derivedObject.AccessProtectedMembers();
        }
    }
}
