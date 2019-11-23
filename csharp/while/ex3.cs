using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {   
            int i =0;
            string cleartext = Console.ReadLine();

/****************************************************
    ********明明有foreach还要用while.********
            foreach(var e in cleartext)
                Console.Write(Convert.ToChar(e+4));
****************************************************/

        while(i < cleartext.Length)
        {
            Console.Write(Convert.ToChar(cleartext[i]+4));
            i++;
        }
            Console.WriteLine();
        }       
    }
}
