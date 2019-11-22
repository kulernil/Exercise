using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=2;
            
            for(int i=101; i<200; i++)
            {
                while(n<=Math.Round(Math.Sqrt(i)))
                {
                    if( i%n==0 ) break;
                    n++;
                }
                if (n > Math.Round(Math.Sqrt(i)))
                    Console.WriteLine(i);
                n=2;
            }


        }
    }
}
