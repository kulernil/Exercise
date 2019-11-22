using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int reg;
            int newline =0;
            for(int i=2; i<=999; i++)
            {
                reg=i;
                if(i%3==0)
                    while(reg>0)
                    {
                        if(reg%10==5)
                        {
                            Console.Write(i+" ");
                            newline++;
                            if(newline==10)
                            {
                                Console.WriteLine();
                                newline=0;
                            }
                            break;
                        }
                        reg /= 10;
                    }
            }
        }   
    }
}
