using System;
using System.Collections.Generic;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for(int i=1; i<=4; i++)
                for(int j=1; j<=4; j++)
                    for(int k=1; k<=4; k++)
                        if(i!=j && j!=k && i!=k)
                            {
                                Console.WriteLine(i*100 + j*10 + k);
                                n++;
                            }
            Console.WriteLine(n);

        }
    }
}
