using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    class Program
    {
        static void Main(string[] args)
        {
        string playerName, choice1, choice2, dragonHeads, weapon, dragonEyes, dragonName;

        Console.Write("Welcome! What is your name? (enter your name): ");
        playerName = Console.ReadLine();
        Console.WriteLine();

            Console.Write("Would you like to play a game? (enter 'yes' or 'no')");
            choice1 = Console.ReadLine();
            Console.WriteLine();

            switch (choice1)
            {
                case "yes":
                    Console.WriteLine("Excellent!");
                    Console.WriteLine();
                    break;
                case "no":
                    Console.WriteLine("Well, all right then. Good-bye.");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
                default:
                    Console.Write("Invalid entry. Try again! ");
                    choice1 = Console.ReadLine();
                    break;
            }
            while (choice1 != "yes" && choice1 != "no")
            {
                Console.Write("Invalid entry. Try again! ");
                choice1 = Console.ReadLine();
            }
            if (choice1 == "no")
            {
                Console.WriteLine("Well, all right then. Good-bye.");
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine("You are walking across a field and you encounter a fire-breathing dragon!  You can: (choose number) ");
            Console.WriteLine();
            Console.WriteLine(" 1. Face the beast!");
            Console.WriteLine(" 2. Run Away!");
            Console.WriteLine();
            Console.Write("What will you do? ");
            choice2 = Console.ReadLine();

            switch (choice2)
            {
                case "1":
                    Console.Write("You approach the dragon.  You see that he has __ heads. (enter 1, 2, or 3): ");
                    dragonHeads = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine("No one has ever faced a " + dragonHeads + "-headed dragon before!  Choose your weapon:");
                    break;
                case "2":
                    Console.WriteLine("Well, that was ALMOST an adventure. " + playerName + " lived a long, boring, safe life.");
                    Console.WriteLine("The End. Press any key to exit");
                    Console.ReadKey();
                   Environment.Exit(0);
                    break;
                default:
                    Console.Write("Invalid entry. Try again! ");
                    choice1 = Console.ReadLine();
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("Bow");
            Console.WriteLine("Sword");
            Console.WriteLine("Staff");
            Console.WriteLine();
            weapon = Console.ReadLine();
            while (weapon != "bow" && weapon != "sword" && weapon != "staff" && weapon != "Sword" && weapon != "Staff" && weapon != "Bow")
            {
                Console.Write("Invalid entry. Try again! ");
                weapon = Console.ReadLine();
            }
            Console.WriteLine();

            Console.Write("Armed with your " + weapon + ", you approach the dragon.  You can feel its fiery breath as you get closer.  It stares at you with its ____ eyes.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Red");
            Console.WriteLine("Blue");
            Console.WriteLine();
            dragonEyes = Console.ReadLine();
            while (dragonEyes != "red" && dragonEyes != "blue" && dragonEyes != "Red" && dragonEyes != "Blue")
            {
                Console.Write("Invalid entry. Try again! ");
                dragonEyes = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Oh, thank goodness!  " + dragonEyes + "-eyed dragons are friendly.  You pet it and become friends.  You name the dragon _______(enter a name): ");
            dragonName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(playerName + " and " + dragonName + " lived happily ever after.");
            Console.WriteLine();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
