using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    public class MyBaseClass
    {
        public string MyProperty { get; set; }
    }

    public class MyDerivedClass : MyBaseClass
    {
        public void AccessBaseProperty()
        {
            MyProperty = "Hello, World!";
            Console.WriteLine($"Derived class accessed MyProperty: {MyProperty}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass derivedObject = new MyDerivedClass();
            derivedObject.AccessBaseProperty();
        }
    }
}
