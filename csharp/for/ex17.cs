using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {   
            int days;
            int peach =1;
            for(days=6; days>0; days--)
            {
                Console.WriteLine("Day{0}: {1} peaches left.", days, peach);
                peach = (peach + 1) * 2;
            }
        }   
    }
}
