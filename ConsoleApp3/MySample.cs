using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class MySample
    {
    }
}


namespace App1
{
    public class SampleClass
    {
        public void M1()
        {
            Console.WriteLine("Hello from App1.Myfolder.MyClass");
        }
    }
    namespace Myfolder
    {
        public class MyClass
        {
            public void MyMethod()
            {
                Console.WriteLine("Hello from App1.Myfolder.MyClass");
            }
        }
    }
}
namespace App2
{
    public class MyClass
    {
        public void MyMethod()
        {
            Console.WriteLine("Hello from App2.MyClass");
        }
    }

}