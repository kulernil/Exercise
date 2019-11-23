using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string  bits;
            int i;
            int letter;
            int number;
            
            i=letter=number=0;

            bits=Console.ReadLine();
            while(i< bits.Length &&  bits[i] != '*')
            {
                if(char.IsNumber(bits[i]))
                    number++;
                if(char.IsLetter(bits[i]))
                    letter++;
                
                i++;
            }

            Console.WriteLine($"There are {letter} letters and {number} numbers.");

        }
    }
}
