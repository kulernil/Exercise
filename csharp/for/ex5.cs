using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int times=1;
            float origin_height= 100;

            while(times < 10)
            {
                Console.WriteLine("{0}:\t{1}m", times, origin_height);
                times++;
                origin_height /= 2;
            }
        }
    }
}
