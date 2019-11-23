using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int n = 1;
            int fac;
            while(n<=1000)
            {
                fac = 1;
                i = 2;
                while(i < Math.Sqrt(n))
                {
                    if(n%i==0)
                        fac += n/i + i;
                    i++;
                }

                if(i*i == n)
                    fac += i;

                if(fac == n)
                    Console.WriteLine(n);
                
                n++;
            }

        }       
    }
}
