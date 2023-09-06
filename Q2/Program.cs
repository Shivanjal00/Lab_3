using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    class A
    {
        private int privateField = 11;

        public int GetPrivateFieldValue()
        {
            return privateField;
        }
    }

    public class B
    {
        public void AccessPrivateFieldFromA()
        {
            A a = new A();
            int value = a.GetPrivateFieldValue();
            Console.WriteLine("Value of privateField in class A: " + value);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            b.AccessPrivateFieldFromA();
        }
    }
}
