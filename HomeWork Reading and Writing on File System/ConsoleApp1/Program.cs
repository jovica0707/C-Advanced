using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FileReader
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Directory.GetCurrentDirectory());
            var filename = @"out.txt";
            if (File.Exists(filename))
            {
                var contents = File.ReadAllLines(filename);
                File.Delete(filename);
                foreach (var line in contents)
                {
                    Console.WriteLine($">> {line} <<");
                }

            }
            else
            {
                string[] contents = { "One", "Two", "Three", "Four", "Five" };
                File.WriteAllLines(filename, contents);
                Console.WriteLine("Written file");

            }




            var tableFile = @"tableFile.txt";

            List<string> result = new List<string>();
            //result = File.ReadAllLines(tableFile).ToList();
            //foreach (String results in result)
           // {
                //Console.WriteLine(results);
           // }



            var writer = new StreamWriter(tableFile, true); 

            //var int i, k, p;
            //List<string> result = new List<string>();
            int i, k, p;
            for (i = 1; i <= 10; i++)
            {
                for (k = 1; k <= 10; k++)
                {
                    p = i * k;
                    var line = $"{i} x {k} =  {p} ";
                    writer.WriteLine(line); ///writerline
                    //result = File.ReadAllLinesAsync(i, k, p).ToString();

                    //result.Add(results);




                }


            }

            //result.Add("i, k, p ");
            //File.WriteAllLines(tableFile, result);

            writer.Close();

            Console.ReadLine();


        }
    }    
    
}