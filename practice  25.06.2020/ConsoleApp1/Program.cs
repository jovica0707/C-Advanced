using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ ID = 101, Name = "John"},
                new Employee{ ID = 102, Name = "Bob"},
                new Employee{ ID = 103, Name = "Dave"},

            };

            //Predicate<Employee> employeePredicate = new Predicate<Employee>(FindEmployee);
            Employee employee = listEmployees.Find((Employee x) => x.ID == 102);
           
            Console.WriteLine("Id ={0}, Name = {1}", employee.ID, employee.Name);

            int count = listEmployees.Count(x => x.Name.StartsWith("M"));
            Console.WriteLine("Count =" + count);

            //var ms = listEmployees.SingleOrDefault();
            //var ms = listEmployees.Single();
            var ms = listEmployees.Where(x => x >)


        }


        //public static bool FindEmployee(Employee Emp)
        //{
        //    return Emp.ID == 102;
        //}

            public class Employee
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
    }


}
