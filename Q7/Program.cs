using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    public class MyClass
    {
        private string privateProperty;
        public MyClass()
        {
            privateProperty = "Initial Value";
        }
        public void ModifyPrivateProperty(string newValue)
        {
            privateProperty = newValue;
        }
        public string GetPrivatePropertyValue()
        {
            return privateProperty;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myObject = new MyClass();

            myObject.ModifyPrivateProperty("New Value");

            string propertyValue = myObject.GetPrivatePropertyValue();
            Console.WriteLine("Private property value: " + propertyValue);
        }
    }
}
