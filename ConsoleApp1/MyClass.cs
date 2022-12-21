using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyClass
    {
        public MyClass()
        {
            Console.WriteLine("Non-Paramerterized Constructor Invoked");
        }
        public MyClass(string name)
        {
            Console.WriteLine("Paramterized Constructor Invoked"+ name);
        }
        static MyClass()
        {
            Console.WriteLine("Static Constructor Invoked");
        }
        const string msh2 = "Hello";
        public int MyProperty { get; set; }
        public static int StaticMember { get; set; } = 0;
        public void Print()
        {
            Console.WriteLine("Print Metod Invoked");
        }
    }

    public static class MyStaticClass
    {
        const string msh2 = "Hello";
        const string Message5 = "Hello";
        const string Message6 = "Hello";
        public static int MyProperty { get; set; }
        public static void Print()
        {
            Console.WriteLine(msh2);
        }
    }
}
