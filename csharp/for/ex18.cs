using System;

namespace ex
{
    class Program
    {
        static void Main(string[] args)
        {   
            int n;
            double ans=1;

            n = Int32.Parse(Console.ReadLine());
            if(n>1)
                {
                    for(int i=2; i<=n; i++)
                        ans += Convert.ToDouble(i - 1) / Convert.ToDouble(i);
                }    
            
                

            Console.WriteLine(ans);

        }   
    }
}
