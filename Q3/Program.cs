using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Q3.Class1;

internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();

            int value = myObject.internalField;
            Console.WriteLine("Value of internalField from another assembly: " + value);
        }
    }
