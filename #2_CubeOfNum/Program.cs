using System;

namespace _2_CubeOfNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            for (var i = 1; i <= 100; i++)
            {  
                sum+=i*i*i;  
                Console.WriteLine($"{sum}");   
            }
            Console.ReadKey();     
        }
    }
}
