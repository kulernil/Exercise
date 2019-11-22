using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {   int total=0;
            for(int n=2; n<=100; n++)
            {
                int factor=2;
                while (factor <= (Math.Sqrt(n)))
                {
                    if (n%factor == 0) break;
                    factor++;
                }
                if(factor > Math.Sqrt(n))
                {
                    Console.Write(n+" ");
                    total++;
                }
                factor=2;
            }
            Console.WriteLine();
            Console.WriteLine("There are {0} primes under 100.", total);
        }
    }
}
