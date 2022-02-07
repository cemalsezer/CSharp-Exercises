using System;


namespace _0_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //two numbers of sum
            int sum = 0;
            Console.Write("Please enter to first num: ");
            int firstNum = int.Parse(Console.ReadLine());
            Console.Write("Please enter to second num: ");
            int secondNum = int.Parse(Console.ReadLine());
            sum=firstNum+secondNum;
            Console.WriteLine($"Sum: {sum}");
            Console.ReadKey();
            

           
        
        }
    }
}
