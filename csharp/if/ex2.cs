using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius;
            double farenheit;

            Console.WriteLine("Please input degree in celsius.");
            celsius = Int32.Parse(Console.ReadLine());
            farenheit = 9/5 * celsius + 32;

            Console.WriteLine("Degree in farenheit is " + farenheit);
        }
    }
}
