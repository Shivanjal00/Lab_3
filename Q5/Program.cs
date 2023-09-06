using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Q5.Class1;

namespace Q5
{
    public class MyDerivedClass : Class1
    {
        public void AccessProtectedInternalMember()
        {
            protectedInternalField = 99;
            Console.WriteLine($"Derived class accessed protectedInternalField: {protectedInternalField}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDerivedClass derivedObject = new MyDerivedClass();
            derivedObject.AccessProtectedInternalMember();
        }
    }
}
