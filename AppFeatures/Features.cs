using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace AppFeatures
{
    internal class MyClass
    {


    }

    public class Features
    {
        public string Message(string msg)
        {
            return msg;
        }


        public int Add(
            out int product, 
            int a = 0, 
            int b = 0)
        {
            product = a * b;
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Divide(int a, int b = 1)
        {
            return a / b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
