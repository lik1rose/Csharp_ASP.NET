using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlFlow_Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (var i = 1; i <= 10; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //for (var i = 10; i >= 0; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}



            //while (true)
            //{
            //    Console.Write("Type your name:");
            //    var input = Console.ReadLine();

            //    if (!String.IsNullOrWhiteSpace(input))
            //    {
            //        Console.WriteLine("@Echo: " + input);
            //        continue; 
            //    }

            //    break; 
            //}

            var ran = new Random();
            for (var i = 0; i < 100; i++)
            {
                Console.Write((char)ran.Next(97, 122));
            }
            Console.WriteLine();

        }
    }
}
