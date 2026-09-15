/*
 * Student ID : 1690703721
 * Name       : Rattanan Rattano
 * Section    : 129D
 * No.        :
 * Course     : GI113 Computer Programming (GI)
 */
namespace Lab05
{
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("==>> MY VIDEO GAME VERY GOD <<==");
                Console.WriteLine("Hero vs. Monster -- Fight Damage Calculator\n");

                Console.Write("Hero Health: ");
                bool heroHpOk = int.TryParse(Console.ReadLine(), out int heroHp);
                Console.Write("Hero Attack: ");
                bool heroAtkOk = int.TryParse(Console.ReadLine(), out int heroAtk);
                Console.Write("Hero Defense: ");
                bool heroDefOk = int.TryParse(Console.ReadLine(), out int heroDef);

                Console.Write("Monster Health: ");
                bool monsterHpOk = int.TryParse(Console.ReadLine(), out int monsterHp);
                Console.Write("Monster Attack: ");
                bool monsterAtkOk = int.TryParse(Console.ReadLine(), out int monsterAtk);
                Console.Write("Monster Defense: ");
                bool monsterDefOk = int.TryParse(Console.ReadLine(), out int monsterDef);

                bool heroStatsValid = heroHpOk && heroAtkOk && heroDefOk;
                bool monsterStatsValid = monsterHpOk && monsterAtkOk && monsterDefOk;
                Console.WriteLine($"\nHero STAT: {heroStatsValid}");
                Console.WriteLine($"Monster STAT: {monsterStatsValid}");

                Console.WriteLine($"[Hero]    HP: {heroHp}, ATK: {heroAtk}, DEF: {heroDef}");
                Console.WriteLine($"[Monster] HP: {monsterHp}, ATK: {monsterAtk}, DEF: {monsterDef}");

                int potionHeal = 5;

                heroHp += potionHeal;
                Console.WriteLine($"\nHero drinks a potion, heals {potionHeal} HP. Hero HP: {heroHp}");

                int normalDmg = Math.Max(0, heroAtk - monsterDef);
                Console.WriteLine($"Hero would deals normal attack: {normalDmg}");
                int powrDmg = Math.Max(0, (heroAtk * 2) - monsterDef);
                Console.WriteLine($"Hero would deals power attack: {powrDmg}");

                Random rng = new Random();
                int critRoll = rng.Next(1, 101);
                bool isCrit = critRoll <= 25;

                int critDmg = normalDmg + (isCrit ? normalDmg : 0);

                Console.WriteLine($"Crit roll {critRoll}. Critical Hit: {isCrit}");
                Console.WriteLine($"If critical hit player would deal {critDmg} DMG!!");
        }
        }
}