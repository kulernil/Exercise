using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {   
            int factor,j;
            for(int i=1; i<=1000; i++)
            {   
                factor=1;
                for(j=2; j<Math.Sqrt(i); j++)
                {
                    if(i%j==0)
                        factor += j+ i/j;
                }
                if(j*j==i)
                    factor +=j;
                if(factor == i)
                    Console.WriteLine(i);
                
            }
        }   
    }
}
