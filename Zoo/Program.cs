using System;

namespace InheritanceEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            string lizardName = Console.ReadLine();
            string snakeName = Console.ReadLine();

            string bearName = Console.ReadLine();
            string gorillaName = Console.ReadLine();

            var lizard = new Lizard(lizardName);
            var snake = new Snake(snakeName);

            var bear = new Bear(bearName);
            var gorilla = new Gorilla(gorillaName);

            Console.WriteLine($"Lizard's name: " + lizard.Name);
            Console.WriteLine($"Snake's name: " + snake.Name);

            Console.WriteLine($"Bear's name: " + bear.Name);
            Console.WriteLine($"Gorilla's name: " + gorilla.Name);

        }
    }
}
