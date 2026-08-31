/*
 * Student ID : 1690703721
 * Name       : Lab02
 * Section    : 129D
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
namespace lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            // Lab02 Part A
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Level: {level}");
            Console.WriteLine($"Hp: {currentHp} / {maxHp}");
            Console.WriteLine($"AttackPower: {attackPower}");
            Console.WriteLine($"CritMultiplier: {critMultiplier}");
            Console.WriteLine($"IsBoss: {isBoss}");
            Console.WriteLine();
            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percent: {hpPercent}%");
            Console.WriteLine();
            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Hp: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"Hp Percent: {hpPercent}%");

            // Lab02 Part B
            string character1Name = "Kratos";
            char rank = 'B';
            int maxHp = 150;
            int strength = 50;
            int armor = 30;
            float attackPower = 9.5f;
            double damageReduction = 0.35;
            bool isCharacter1 = true;

            Console.WriteLine("===== CHARACTER 1 STATUS =====");
            Console.WriteLine($"Name: {character1Name}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Strength: {strength}");
            Console.WriteLine($"Armor: {armor}");
            Console.WriteLine($"Attack Power: {attackPower}");
            Console.WriteLine($"Damage Reduction: {damageReduction}");
            Console.WriteLine($"Is Character 1: {isCharacter1}");
            Console.WriteLine();

            string character2Name = "Eldritch";
            char rank = 'S';
            int maxMp = 150;         
            int maxHp = 100;
            float magicAttack = 50.5f;
            float mpRegen = 10f;
            double critMultiplier = 1.5;
            bool isCharacter2 = true;

            Console.WriteLine("===== CHARACTER 2 STATUS =====");   
            Console.WriteLine($"Name: {character2Name}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Max MP: {maxMp}");
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Magic Attack: {magicAttack}");
            Console.WriteLine($"MP Regen: {mpRegen}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is Character 2: {isCharacter2}");

            string character3Name = "Atalanta";
            char rank = 'A';
            int maxHp = 80;           
            float moveSpeed = 7.5f;
            float attackSpeed = 2.0f;
            float armorPenetration = 30.5f;
            double critRate = 0.50;
            double dodgeChance = 0.40;
            bool isCharacter3 = true;

            Console.WriteLine("===== CHARACTER 3 STATUS =====");
            Console.WriteLine($"Name: {character3Name}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Move Speed: {moveSpeed}");
            Console.WriteLine($"Attack Speed: {attackSpeed}");
            Console.WriteLine($"Armor Penetration: {armorPenetration}");
            Console.WriteLine($"Crit Rate: {critRate}");
            Console.WriteLine($"Dodge Chance: {dodgeChance}");
            Console.WriteLine($"Is Character 3: {isCharacter3}");

            string character4Name = "Lucius";
            char rank = 'C';
            int maxMp = 100;
            int maxHp = 125;
            int healPower = 15;
            float healthRegen = 5.0f;
            double healBonus = 0.5;
            bool isCharacter4 = true;

            Console.WriteLine("===== CHARACTER 4 STATUS =====");
            Console.WriteLine($"Name: {character4Name}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"Max MP: {maxMp}");
            Console.WriteLine($"Max HP: {maxHp}");
            Console.WriteLine($"Heal Power: {healPower}");
            Console.WriteLine($"Health Regen: {healthRegen}");
            Console.WriteLine($"Heal Bonus: {healBonus}");
            Console.WriteLine($"Is Character 4: {isCharacter4}");
        }
    }
}
