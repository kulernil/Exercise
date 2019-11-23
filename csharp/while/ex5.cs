using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, remainder, reg;
            reg=0;

            n=Int32.Parse(Console.ReadLine());
            while(n>0)
            {
                remainder = n%10;
                reg += remainder;
                Console.Write(remainder + (n > 10 ? "+" : ""));

                n /= 10;
            }

            Console.WriteLine();
            Console.WriteLine("=" + reg);

        }
    }
}
