using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            float i, j;
            float tmp=0;
            i=1; j=2;

            Console.Write("tmp=");
            for(int k=1; k<=20; k++)
            {
                tmp += j/i;
                Console.Write((k == 20) ? $"{j}/{i}" : $"{j}/{i}+");
                j = j + i;
                i = j - i;         
            }
            Console.WriteLine();
            Console.WriteLine("="+tmp);
        }
    }
}
