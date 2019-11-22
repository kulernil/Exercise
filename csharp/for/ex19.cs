using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {   
            for(int i=1; i<=30; i++)
                for(int j=1; j<=30; j++ )
                    for(int k=1; k<=j; k++)
                        if(i*i==j*j+k*k)
                            Console.WriteLine("{0}, {1}, {2}",i,j,k);

        }   
    }
}
