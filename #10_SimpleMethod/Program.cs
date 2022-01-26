using System;

namespace _10_SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {//Example for ctor
            int id; string name, surname;
            Console.Write($"Id: ");
            id =int.Parse(Console.ReadLine());
            Console.Write($"Name: ");
            name = Console.ReadLine();
            Console.Write($"Surname: ");
            surname = Console.ReadLine();
            studentRegister stdReg = new studentRegister(id,name,surname);
            

            Console.Write(stdReg.Id+" ");
            Console.Write(stdReg.Name+" ");
            Console.Write(stdReg.surName+" ");


          
        }
    }
}
