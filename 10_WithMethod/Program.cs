using System;

namespace _9_WithMethod
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write($"Please enter the number you want to square: ");
             double answer = double.Parse(Console.ReadLine());
                var x = square(answer);         
                Console.WriteLine($"Square: {x}");
        }

        static double square(double x){

            double squareZone =x*x;
            return squareZone;
        }
    }
}
