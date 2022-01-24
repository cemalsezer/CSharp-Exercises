using System;

namespace _5_WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
             int character = 0;
             Console.Write("Please enter to sentence: ");
             string answer = Console.ReadLine();
             string[] words = answer.Split(" ");
             Console.WriteLine($" Words Count: {words.Length}");
             for (var i = 0; i < words.Length; i++)
             {
                 char[] characterZone = words[i].ToCharArray();
                 character+=characterZone.Length;
             }
            Console.WriteLine($"Character Count: {character}");
            
          
        }
    }
}
