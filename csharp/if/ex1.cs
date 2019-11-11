using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,y,z;
            double average, product;

            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            z = Int32.Parse(Console.ReadLine());

            average = ( x + y + z ) / 2;
            product =  x * y * z;

            Console.WriteLine("The average of numbers is " + average);
            Console.WriteLine("The product of numbers is " + product);
            Console.WriteLine("Hello World!");
        }
    }
}