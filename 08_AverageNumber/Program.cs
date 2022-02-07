using System;

namespace _7_AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum=0, sumAverage; 
            Console.Write("Please enter to loop's num: ");
            int answer = int.Parse(Console.ReadLine());
            for (int i = 1; i <= answer; i++)
            {
                sum+=i;
            }
            sumAverage= sum/answer;
            if(sumAverage>50){
                Console.WriteLine("Average is bigger than 50");
                
            }
            else{
                Console.WriteLine("Average is smaller than 50");
            }
      
        }
    }
}
