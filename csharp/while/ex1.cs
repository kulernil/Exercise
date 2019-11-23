using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, tmp;
            long ans;

            do 
            {
                Console.WriteLine("Please insert n, and n < 7");
                a=Int32.Parse(Console.ReadLine());
            }
            while (n > 7 );
            Console.WriteLine("Please insert a");
            a=Int32.Parse(Console.ReadLine());
            
            ans = 0;
            tmp = a;

            Console.Write("ans=");
            while(n > 0)
            {
                ans += tmp;
                Console.Write(tmp+(n>1 ? "+":""));
                n--;
                tmp = (tmp * 10) + a;
            }
            Console.WriteLine();
            Console.WriteLine("="+ans);
        }       
    }
}
