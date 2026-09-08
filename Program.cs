using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("+----------------------+");
            Console.WriteLine("|     NEW ADVENTURE     |");
            Console.WriteLine("+----------------------+");
            Console.Write("Name your hero: ");
            String playerName = Console.ReadLine();
            Console.WriteLine($"\n\"Welcome, {playerName}. Your journey begins...\"");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("|   DIFFICULTY SELECT   |");
            Console.WriteLine("+----------------------+");
            Console.Write("Choose difficulty (1-3): ");
            int difficulty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\"Difficulty {difficulty} selected. Good luck out there...\"");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("|       ITEM SHOE       |");
            Console.WriteLine("+----------------------+");
            Console.Write("How many potions? ");
            bool isValid = int.TryParse(Console.ReadLine(), out int quantity);
            Console.WriteLine($"Valid input: {isValid}");   
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine("+----------------------+");
            Console.WriteLine("|   CHARACTER CREATION  |");
            Console.WriteLine("+----------------------+");
            Console.Write("Name your character: ");
            string charName = Console.ReadLine();
            Console.Write("Choose a class (1-3): ");
            bool classOk = int.TryParse(Console.ReadLine(), out int classNum);
            Console.Write("Starting Luck (0.0-10.0): ");
            bool luckOk = double.TryParse(Console.ReadLine(), out double luck);
            Console.WriteLine($"\n{charName} the Class-{classNum} adventrer enters the dungeon. Luck: {luck}");
        }
    }
}