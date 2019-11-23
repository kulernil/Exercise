using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int tmp,fac;
            
            int n = Int32.Parse(Console.ReadLine());
            tmp=0;

            while(n>0)
            {  
                 int i = n;
                 fac = 1;
                while(i > 0)
                {
                    fac *= i;
                    i--;
                }
                Console.Write(fac + (n>1 ? "+" : ""));
                tmp += fac;
                n--;
            }
            
            Console.WriteLine();
            Console.WriteLine("="+tmp);
        }
    }
}
