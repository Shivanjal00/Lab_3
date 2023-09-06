using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    public class MyClass
    {
        private int myPrivateField=0;

        public void SetPrivateFieldValue(int value)
        {
            myPrivateField = value;
        }

        public int GetPrivateFieldValue()
        {
            return myPrivateField;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();

            myObject.SetPrivateFieldValue(42);

            int fieldValue = myObject.GetPrivateFieldValue();
            Console.WriteLine("Private field value: " + fieldValue);
        }
    }
}
