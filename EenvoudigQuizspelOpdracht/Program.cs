// See https://aka.ms/new-console-template for more information
using System;
using static EenvoudigQuizspelOpdracht.Program;


namespace EenvoudigQuizspelOpdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EenvoudigQuizspelOpdracht...");
            User Jeroen = new User();
            Jeroen.AddName("Jeroen", "Maassen van den Brink");
            string FullNameJeroen = Jeroen.getName();
            
            Console.WriteLine(FullNameJeroen);
        }
        

    }

    
}