using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace check_odd_even
{
    public class Program
    {
        //check even and odd number
        public static void Main(string[] args)
        {
            int num1, rem1;
            Console.Write("\n\n");
            Console.Write("Check whether a number is even or odd :\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");
            Console.Write("Input an integer : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("{0} is an even integer.\n", num1);
            else
                Console.WriteLine("{0} is an odd integer.\n", num1);
        }

        //public static IHostBuilder CreateHostBuilder(string[] args) =>
          //  Host.CreateDefaultBuilder(args)
                //.ConfigureWebHostDefaults(webBuilder =>
              //  {
                    //webBuilder.UseStartup<Startup>();
               // });
    }
}
