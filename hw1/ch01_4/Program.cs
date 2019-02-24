using System;

namespace ch01_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a=0, b=0;
            Console.WriteLine("Please input two numbers");
            a=Convert.ToDouble(Console.ReadLine());
            b=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The product is "+a*b);

        }
    }
}
