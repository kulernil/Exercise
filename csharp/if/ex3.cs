using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int length, width, height;
            double volume, area;
            
            Console.WriteLine("Please insert length, width and height:\n");
            length = Int32.Parse(Console.ReadLine());
            width  = Int32.Parse(Console.ReadLine());
            height = Int32.Parse(Console.ReadLine());

            volume = length * width * height;
            area = ( length * width + length * height + width * height ) * 2;

            Console.WriteLine($"The volume is {volume} and area is {area}.");

        }
    }
}
