using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Month: ");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Day: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Year: ");
            int year = int.Parse(Console.ReadLine());

            DateTime date = new DateTime(year, month, day);

            DateTime notWorking1 = new DateTime(2020, 01, 01);
            DateTime notWorking2 = new DateTime(2020, 01, 07);
            DateTime notWorking3 = new DateTime(2020, 04, 20);
            DateTime notWorking4 = new DateTime(2020, 05, 01);
            DateTime notWorking5 = new DateTime(2020, 05, 25);
            DateTime notWorking6 = new DateTime(2020, 08, 03);
            DateTime notWorking7 = new DateTime(2020, 09, 08);
            DateTime notWorking8 = new DateTime(2020, 10, 12);
            DateTime notWorking9 = new DateTime(2020, 10, 23);
            DateTime notWorking10 = new DateTime(2020, 12, 8);

            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("Is not a working day");
            }
            else if (date == notWorking1 || date == notWorking2 || date == notWorking3)
            {
                Console.WriteLine("Is not working day");
            }
            else
            {
                Console.WriteLine("Is working day");
            }
            Console.ReadLine();
        }
    }
}
