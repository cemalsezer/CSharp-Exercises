using System;

namespace _1_SquareOfNum
{
    class Program
    {
        static void Main(string[] args)
        {   //Exercise second
            //The sum of the squares of the two numbers entered
            int sum = 0, squareFirst=0, squareSecond=0;
            Console.Write("Please enter to first num: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter to second num: ");
            int secondNum = int.Parse(Console.ReadLine());
            squareFirst=firstNum*firstNum;
            squareSecond=secondNum*secondNum;
            sum=squareFirst+squareSecond;
            Console.WriteLine($"Sum: {sum}");
            Console.ReadKey();
        }
    }
}
