using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere!");
            Console.WriteLine("Mis su nimi on?");
            string name;

            name = Console.ReadLine();

            Console.WriteLine("Tere " + name + "!");
            Console.WriteLine("Mis aastal sa sündisid?");
            int year;
            year = int.Parse(Console.ReadLine());
            int age = 2019 - year;
            Console.WriteLine("Sa oled " + age + " vana.");
            Console.ReadLine();
        }
    }
}
