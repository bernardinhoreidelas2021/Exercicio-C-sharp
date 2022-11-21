using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIGITE UM NUMERO:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());  
            if (a % b == 0) {
                Console.WriteLine("SAO MULTIPLOS"); 

            }
            else if (b % a == 0)
            {
                Console.WriteLine("SAO MULTIPLOS");
            }
            else
            {
                Console.WriteLine("NAO SAO MULTIPLOS");
            }

        }
    }
}