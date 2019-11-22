using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfnumbers = new int[] {1,2,3,4,5};
            Array.Reverse(arrayOfnumbers);
            foreach(var e in arrayOfnumbers)
                Console.WriteLine(e);

        }
    }
}
