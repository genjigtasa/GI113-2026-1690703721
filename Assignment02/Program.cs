/*
 * Student ID : 1690703721
 * Name       : Rattanan Rattano
 * Section    : 129D
 * No.        : 5
 * Course     : GI113 Computer Programming (GI)
 */
namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MaterialName = "Lumina";
            const double SmeltRate = 0.2500;
            const double SalvageRate = 0.3000;
            const double MaxBatch = 500.00;

            Console.WriteLine("------------------------------------");
            Console.WriteLine("- -     -The Forge of Light-     - -");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"=> {MaterialName} Smelting {SmeltRate:F2} / Salvage {SalvageRate:F2}");
            Console.WriteLine("=> Key 'S' for Smelt (Ore -> Ingot)");
            Console.WriteLine("=> Key 'B' for Breakdown (Ingot -> Ore)");

            Console.Write("=> Choose Menu: ");
            string menuInput = Console.ReadLine();

            Console.Write("=> How much would you like: ");
            string amountInput = Console.ReadLine();

            bool isMenuValid = char.TryParse(menuInput, out char menu);
            bool isAmountValid = double.TryParse(amountInput, out double amount);

            if (isAmountValid && amount > 0 && amount <= MaxBatch)
            {
                if (isMenuValid && (menu == 'S' || menu == 's'))
                {
                    double ingotResult = amount * SmeltRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ore = {ingotResult:F2} {MaterialName} Ingot");
                }
                else if (isMenuValid && (menu == 'B' || menu == 'b'))
                {
                    double oreResult = amount / SalvageRate;
                    Console.WriteLine($"=> {amount:F2} {MaterialName} Ingot = {oreResult:F2} {MaterialName} Ore");
                }
                else
                {
                    Console.WriteLine("Error: Invalid menu selection. Please choose 'S' or 'B'.");
                }
            }
            else
            {
                Console.WriteLine($"Error: Invalid amount. Amount must be a positive number up to {MaxBatch:F2}.");
            }
        }
    }
}