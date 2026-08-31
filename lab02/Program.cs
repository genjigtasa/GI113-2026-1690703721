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
            char c1rank = 'B';
            int c1maxHp = 150;
            int c1strength = 50;
            int c1armor = 30;
            float c1attackPower = 9.5f;
            double c1damageReduction = 0.35;
            bool isCharacter1 = true;

            Console.WriteLine("===== CHARACTER 1 STATUS =====");
            Console.WriteLine($"Name: {character1Name}");
            Console.WriteLine($"Rank: {c1rank}");
            Console.WriteLine($"Max HP: {c1maxHp}");
            Console.WriteLine($"Strength: {c1strength}");
            Console.WriteLine($"Armor: {c1armor}");
            Console.WriteLine($"Attack Power: {c1attackPower}");
            Console.WriteLine($"Damage Reduction: {c1damageReduction}");
            Console.WriteLine($"Is Character 1: {isCharacter1}");
            Console.WriteLine();

            string character2Name = "Eldritch";
            char c2rank = 'S';
            int c2maxMp = 150;         
            int c2maxHp = 100;
            float c2magicAttack = 50.5f;
            float c2mpRegen = 10f;
            double c2critMultiplier = 1.5;
            bool isCharacter2 = true;

            Console.WriteLine("===== CHARACTER 2 STATUS =====");   
            Console.WriteLine($"Name: {character2Name}");
            Console.WriteLine($"Rank: {c2rank}");
            Console.WriteLine($"Max MP: {c2maxMp}");
            Console.WriteLine($"Max HP: {c2maxHp}");
            Console.WriteLine($"Magic Attack: {c2magicAttack}");
            Console.WriteLine($"MP Regen: {c2mpRegen}");
            Console.WriteLine($"Crit Multiplier: {c2critMultiplier}");
            Console.WriteLine($"Is Character 2: {isCharacter2}");

            string character3Name = "Atalanta";
            char c3rank = 'A';
            int c3maxHp = 80;           
            float c3moveSpeed = 7.5f;
            float c3attackSpeed = 2.0f;
            float c3armorPenetration = 30.5f;
            double c3critRate = 0.50;
            double c3dodgeChance = 0.40;
            bool isCharacter3 = true;

            Console.WriteLine("===== CHARACTER 3 STATUS =====");
            Console.WriteLine($"Name: {character3Name}");
            Console.WriteLine($"Rank: {c3rank}");
            Console.WriteLine($"Max HP: {c3maxHp}");
            Console.WriteLine($"Move Speed: {c3moveSpeed}");
            Console.WriteLine($"Attack Speed: {c3attackSpeed}");
            Console.WriteLine($"Armor Penetration: {c3armorPenetration}");
            Console.WriteLine($"Crit Rate: {c3critRate}");
            Console.WriteLine($"Dodge Chance: {c3dodgeChance}");
            Console.WriteLine($"Is Character 3: {isCharacter3}");

            string character4Name = "Lucius";
            char c4rank = 'C';
            int c4maxMp = 100;
            int c4maxHp = 125;
            int c4healPower = 15;
            float c4healthRegen = 5.0f;
            double c4healBonus = 0.5;
            bool isCharacter4 = true;

            Console.WriteLine("===== CHARACTER 4 STATUS =====");
            Console.WriteLine($"Name: {character4Name}");
            Console.WriteLine($"Rank: {c4rank}");
            Console.WriteLine($"Max MP: {c4maxMp}");
            Console.WriteLine($"Max HP: {c4maxHp}");
            Console.WriteLine($"Heal Power: {c4healPower}");
            Console.WriteLine($"Health Regen: {c4healthRegen}");
            Console.WriteLine($"Heal Bonus: {c4healBonus}");
            Console.WriteLine($"Is Character 4: {isCharacter4}");
        }
    }
}
