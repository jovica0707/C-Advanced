using System;
using System.Linq;

namespace ConsoleApp2
{
    delegate int Multiply(int n);
    class Program
    {
        static void Main(string[] args)
        {
            Multiply MultiplyNumber = n => n * 3;
            Console.WriteLine(MultiplyNumber(20));
        }
    }
}
