using System;

namespace _4_AssignToArray
{
    class Program
    {
        static void Main(string[] args)
        {//Prints the entered words in reverse.

              Console.Write("Please enter to loop's num: ");
            int loopNum = int.Parse(Console.ReadLine());
            string[] answer = new string[loopNum];
             
                for (int j = 0; j < answer.Length; j++)
                {
                    Console.Write("{0}: Please enter to word : ",j+1);
                    answer[j] = Console.ReadLine();
                }
                Array.Reverse(answer);
                foreach (var item in answer)
                {
                    Console.WriteLine(item);
                }
        }
    }
}
