using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///DoSomething(Function, "Hello");
            DoSomething(x =>
            {
                Console.WriteLine(x);
            }
                , "Hello");
        }
        public static void Function(string x)
        {
            Console.WriteLine(x);
        }

        public static void DoSomething(Action<string> action, string input)
        {
            action(input);
        }
    }
}
