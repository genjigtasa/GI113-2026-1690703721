/*
 * Student ID : 1690703721
 * Name       : Rattanan Rattano
 * Section    : 129D
 * No.        : 5
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab06
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            int swordDmg = 5;
            int GreatswordDmg = 15;
            int ArcherDmg = 10;
            int enemyHp = 30;
            int heroHp = 100;
            int bandageHeal = 20;

            Console.WriteLine("GAME TITLE: BERSERK KNIGHT");
            
            Console.WriteLine("ACTION 1: ATTACK WITH SWORD");
            Console.WriteLine("ACTION 2: ATTACK WITH GREATSWORD");
            Console.WriteLine("ACTION 3: SHOOT WITH BOW");
            Console.WriteLine("ACTION 4: USE BANDAGE");

            Console.Write("+++> CHOOSE YOUR NEXT MOVES (1-4): ");
            bool inputValid = int.TryParse(Console.ReadLine(), out int choice);

            if (!inputValid || choice < 1 || choice > 4)
            {

            }
            else if (choice == 1)
            {
                enemyHp -= swordDmg;
                if (enemyHp <= 0)
                {
                    Console.WriteLine($"Hero slashed with Sword for {swordDmg} DMG. Enemy died!");
                }
                else
                {
                    Console.WriteLine($"Hero slashed with Sword for {swordDmg} DMG. Enemy has {enemyHp} HP left.");
                }
            }
            else if (choice == 2)
            {
                enemyHp -= GreatswordDmg;
                if (enemyHp <= 0)
                {
                    Console.WriteLine($"Hero swung a greatsword for {GreatswordDmg} DMG. Enemy died!");
                }
                else
                {
                    Console.WriteLine($"Hero swung a greatsword for {GreatswordDmg} DMG. Enemy has {enemyHp} HP left.");
                }
            }
            else if (choice == 3)
            {
                enemyHp -= ArcherDmg;
                if (enemyHp <= 0)
                {
                    Console.WriteLine($"Hero shot an arrow for {ArcherDmg} DMG. Enemy died!");
                }
                else
                {
                    Console.WriteLine($"Hero shot an arrow for {ArcherDmg} DMG. Enemy has {enemyHp} HP left.");
                }
            }
            else if (choice == 4)
            {
                heroHp += bandageHeal;
                Console.WriteLine($"Hero used a bandage and healed for {bandageHeal} HP. Hero now has {heroHp} HP.");
            }
        }
    }
}
