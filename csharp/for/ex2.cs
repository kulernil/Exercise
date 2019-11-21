using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            int i = 0;
             while( n < 100000 )
                {
                    if ((Math.Truncate(Math.Sqrt(n+100)) == (Math.Sqrt(n+100))) && (Math.Truncate(Math.Sqrt(n+268)) != Math.Sqrt(n+268)))
                        {
                            Console.WriteLine(n);
                            i++;
                            };
                    n++;
                } 
            Console.WriteLine(i);
        }
    }
}
