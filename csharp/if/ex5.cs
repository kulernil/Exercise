using System;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int hundreds, tens, ones;

            n = Int32.Parse(Console.ReadLine());
            
            hundreds = n / 100;
            tens = ( n % 100 ) / 10;
            ones = ( n % 10 );

            Console.Write(ones);
            Console.Write(tens);
            Console.Write(hundreds);

        }
    }
}
