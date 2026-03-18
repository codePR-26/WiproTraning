// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using ConsoleApp4;
using System.Collections;

namespace ConsoleApp4
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            DeligateExample de = new DeligateExample();

            //func, Action, Predicate
            List<int> results = new List<int>();
            Func<int, int> func1 = de.Square;
            func1 += de.Double;
            Console.WriteLine(func1(10));
            var Invoclist = func1.GetInvocationList().Cast<Func<int, int>>();
            foreach (var invlist in Invoclist)
            {
               int result = invlist.Invoke(10);
                results.Add(result);
               
            }
            foreach (int i in results)
            {
                Console.WriteLine(i);
            }

        }
    }

    public class DeligateExample
    {

        public int Double(int x)
        {
            return x + x;
        }
        public int Square(int x)
        {
            return x * x;
        }

      
        public void Cube(int x)
        {
            Console.WriteLine(x * x * x);
        }

    }
}

