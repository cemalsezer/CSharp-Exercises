using System;

namespace _8_MultiDimensional
{
    class Program
    { 
        static void Main(string[] args)
        { //Printing cities as much as the value of the entered dimensional array
            int lineOfArray= 0, colmOfArray=0,i,j;

            Console.WriteLine("Please enter the line of the directory");
            lineOfArray=int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the colm of the directory");
            colmOfArray=int.Parse(Console.ReadLine());
            int[,] arrayOfAnswer = new int[lineOfArray,colmOfArray];
            string[,] cityName = new string[lineOfArray,lineOfArray];

            for (  i=0 ; i < arrayOfAnswer.GetLength(0); i++)
            {   
                    for ( j=0 ; j <arrayOfAnswer.GetLength(1); j++)
                    {
                            Console.Write("CityName: ");
                            cityName[i,j]=Console.ReadLine();                        
                    }
            } Console.WriteLine();      
            foreach (var item in cityName)
               {
                        Console.Write($"{item,5}");
               }           
                     
        }
    }
}
