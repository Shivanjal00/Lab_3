using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    public class MyClass
    {

        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }

        public void PublicMethod()
        {
            Console.WriteLine("This is a public method.");
            PrivateMethod();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();

            myObject.PublicMethod();
        }
    }
}
