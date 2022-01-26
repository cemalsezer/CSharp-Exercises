using System;

namespace _10_SimpleMethod
{
    class Program
    {
        static void Main(string[] args)
        {//Example for ctor
            int id; string name, surName;
            Console.Write("Id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            name = Console.ReadLine();
             Console.Write("Surname: ");
            surName = Console.ReadLine();

            studentRegister stnd =new studentRegister(id,name,surName);

            Console.Write($"Id NO: {id}"+" ");
            Console.Write($"Name: {name}"+" ");
            Console.Write($"Surname: {surName}"+" ");

            


        }
    }
}
