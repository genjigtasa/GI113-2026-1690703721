/*
* Student ID : 1690703721
* Name       : Rattanan Rattano
* Section    : 129D
* No.        :
* Course     : GI113 Computer Programming (GI)
*/
using System;

namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string GameTitle = "fisch";

            var fisherName = "PoseidonNightmare";
            var currentBaits = 'B';

            int totalFishCaught = 5000;
            float luckMultiplier = 2.5f;
            double progressSpeed = 9.8;
            bool isBated = true;

            Console.WriteLine($"========================================");
            Console.WriteLine($"============== {GameTitle} ==============");
            Console.WriteLine($"========================================");
            Console.WriteLine($"Fisher Name   : {fisherName}");
            Console.WriteLine($"Bait Type     : {currentBaits}");
            Console.WriteLine($"Fish Caught   : {totalFishCaught} fish");
            Console.WriteLine($"Luck Boost    : {luckMultiplier}x");
            Console.WriteLine($"Rod Speed     : {progressSpeed} m/s");
            Console.WriteLine($"Bait Equipped : {isBated}");
            Console.WriteLine($"----------------------------------------");

            double totalFishCaughtDouble = totalFishCaught;
            Console.WriteLine($"Fish Count (implicit double) : {totalFishCaughtDouble}");

            int progressSpeedCast = (int)progressSpeed;
            int progressSpeedConvert = Convert.ToInt32(progressSpeed);

            Console.WriteLine($"Rod Speed Cast (int)      : {progressSpeedCast}");
            Console.WriteLine($"Rod Speed Convert.ToInt32 : {progressSpeedConvert}");
            Console.WriteLine($"==========================================");
        }
    }
}
