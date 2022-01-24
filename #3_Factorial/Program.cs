using System;

namespace _3_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int fac=1;
            Console.Write("Please enter to first num: ");
            int firstNum = int.Parse(Console.ReadLine());

            for (var i = firstNum; i>1; i--)
            {   
                 fac=fac*i;
            }
                 Console.WriteLine($"{fac}");
                 Console.ReadKey();
        } 
    }
}
