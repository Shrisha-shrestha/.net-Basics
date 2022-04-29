using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World ");//printf

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = a + b;


            string a = Convert.ToString(Console.ReadLine());
            if (a=="5")
            {
                Console.WriteLine("Five");
            }
            else if(a=="25")
            {
                Console.WriteLine("Twenty five");
            }
            else
            {
                Console.WriteLine("Enter from 1 to 25");
            }
            Console.ReadLine();

        }
    }
}
