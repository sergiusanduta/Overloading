using Microsoft.VisualBasic;
using System;

namespace ConsoleApp3
{
    class MyClass
    {
        MyClass my = null;

        private void Method()
        {
            Console.WriteLine("Hello");
        }

        public void CallMethod()
        {
            my = new MyClass(); //// ? what is this  /.?

            my.Method();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            MyClass my = new MyClass();
            my.CallMethod();
           
        }
    }
}
