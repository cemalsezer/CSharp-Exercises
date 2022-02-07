using System;

namespace _6_SquareOfUser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finding the sum of the squares of n numbers entered from the keyboard
            double sum=0;
            Console.Write("Please enter to loop's num: ");
            int loopNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= loopNum; i++)
            {
                Console.Write($"{i}. enter the number: ");
                int answer=int.Parse(Console.ReadLine());
                sum+= Math.Pow(answer,2);
            }
            Console.WriteLine($"The sum of the squares of the entered numbers: {sum}");
            
        }
    }
}
