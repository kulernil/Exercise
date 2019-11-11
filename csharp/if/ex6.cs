using System;

namespace ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char c1 = s[0];
            char c2 = s[1];
            char c3 = s[2];

            int a, b, c;
            a = c1 - c2;
            b = c2 - c3;
            c = c1 - c3;
            
            if( (( a == 1 ) || ( a == -1 )) ||
                (( b == 1 ) || ( b == -1 )) ||
                (( c == 1 ) || ( c == -1 )) )
                {
                    Console.Write("TRUE");
                }
            else
                {
                    Console.Write("FALSE"); 
                }
        }
    }
}