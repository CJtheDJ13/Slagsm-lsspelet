using System.Drawing;
using System.Formats.Asn1;
using System.Numerics;
using System.Reflection.Metadata;
using System.Resources;

bool playAgain = true;

while (playAgain)
{

    int playerHealth = 100 + Random.Shared.Next(101);
    int player2Health = 100 + Random.Shared.Next(101);
    int round = 1;

    int playerMaxDamage = 30 + player2Health - 100;
    int player2MaxDamage = 30 + playerHealth - 100;

    string name;
    string name2;

    Console.Clear();
    Console.WriteLine("--- WELCOME TO THE GLADIATOR ARENA ---");
    Thread.Sleep(1500);
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine("(1): 1v1");
    Console.WriteLine("(2): Random Enemy");
    Console.WriteLine("(3): Boss Battle");
    Console.WriteLine("(4): Instructions");
    Console.ForegroundColor = ConsoleColor.White;

    string choice = "";
    while (choice != "1" && choice != "2" && choice != "3" && choice != "4")
    {
        choice = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("You can only type: 1, 2, 3 or 4!");
        Console.ResetColor();
    }

    if (choice == "1")
    {
        Console.Clear();
        Console.WriteLine("Please state the first gladiators name:");
        name = Console.ReadLine().ToUpper();
        while (name.Contains(" ") || name.Length > 10 || string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Your name cannot have spaces and cannot be more than 10 words, neither can it be empty!");
            name = Console.ReadLine().ToUpper();
        }

        Console.WriteLine("Please state the second gladiators name:");
        name2 = Console.ReadLine().ToUpper();
        while (name2.Contains(" ") || name2.Length > 10 || string.IsNullOrWhiteSpace(name2))
        {
            Console.WriteLine("Your name cannot have spaces and cannot be more than 10 words, neither can it be empty!");
            name2 = Console.ReadLine().ToUpper();
        }

        Console.Clear();
        Console.WriteLine($"--- Today in the arena we have {name} VS {name2}! ---");
        Thread.Sleep(1000);
        Console.WriteLine("---------------=================---------------");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"{name}'s Health = {playerHealth}        {name2}'s Health = {player2Health}");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"{name}'s Max Damage = {playerMaxDamage}        {name2}'s Max Damage = {player2MaxDamage}");
        Thread.Sleep(1250);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

        while (playerHealth > 0 && player2Health > 0)
        {
            int playerDamage = Random.Shared.Next(playerMaxDamage);
            int player2Damage = Random.Shared.Next(player2MaxDamage);

            Console.Clear();
            Console.WriteLine($"---=== Round {round} ===---");
            Thread.Sleep(1000);

            playerHealth -= player2Damage;
            playerHealth = Math.Max(0, playerHealth);
            player2Health -= playerDamage;
            player2Health = Math.Max(0, player2Health);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{name} did {playerDamage} damage to {name2}");
            Console.WriteLine($"{name2} did {player2Damage} damage to {name}");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------=================---------------");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{name} now has {playerHealth} health");
            Console.WriteLine($"{name2} now has {player2Health} health");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press ENTER to continue");

            round += 1;

            Console.ReadLine();
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;

        Console.Clear();
        if (playerHealth <= 0 && player2Health <= 0)
        {
            Console.WriteLine("Both gladiators have died!");
            Thread.Sleep(2000);
        }
        else if (playerHealth <= 0)
        {
            Console.WriteLine($"{name} was killed by {name2}!");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine($"{name2} was killed by {name}!");
            Thread.Sleep(2000);
        }
    }
    else if (choice == "2")
    {
        var nameList = new List<string> { "Henke", "Pelle", "Fredrik", "Sören", "Ulf", "Kalle", "Göran" };
        var randomName = new Random();
        name2 = nameList[randomName.Next(0, nameList.Count)];

        Console.Clear();
        Console.WriteLine("Please state your name:");
        name = Console.ReadLine().ToUpper();
        while (name.Contains(" ") || name.Length > 10 || string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Your name cannot have spaces and cannot be more than 10 words, neither can it be empty!");
            name = Console.ReadLine().ToUpper();
        }

        Console.Clear();
        Console.WriteLine($"--- Today in the arena we have {name} VS {name2}! ---");
        Thread.Sleep(1000);
        Console.WriteLine("---------------=================---------------");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"{name}'s Health = {playerHealth}        {name2}'s Health = {player2Health}");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"{name}'s Max Damage = {playerMaxDamage}        {name2}'s Max Damage = {player2MaxDamage}");
        Thread.Sleep(1250);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

        while (playerHealth > 0 && player2Health > 0)
        {
            int playerDamage = Random.Shared.Next(playerMaxDamage);
            int player2Damage = Random.Shared.Next(player2MaxDamage);

            Console.Clear();
            Console.WriteLine($"---=== Round {round} ===---");
            Thread.Sleep(1000);

            playerHealth -= player2Damage;
            playerHealth = Math.Max(0, playerHealth);
            player2Health -= playerDamage;
            player2Health = Math.Max(0, player2Health);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{name} did {playerDamage} damage to {name2}");
            Console.WriteLine($"{name2} did {player2Damage} damage to {name}");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------=================---------------");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{name} now has {playerHealth} health");
            Console.WriteLine($"{name2} now has {player2Health} health");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press ENTER to continue");

            round += 1;

            Console.ReadLine();
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;

        Console.Clear();
        if (playerHealth <= 0 && player2Health <= 0)
        {
            Console.WriteLine("Both gladiators have died!");
            Thread.Sleep(2000);
        }
        else if (playerHealth <= 0)
        {
            Console.WriteLine($"{name} was killed by {name2}!");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine($"{name2} was killed by {name}!");
            Thread.Sleep(2000);
        }
    }
    else if (choice == "3")
    {
        name2 = "ALFRED";
        player2MaxDamage += 100;
        player2Health += 100;

        Console.Clear();
        Console.WriteLine("Please state your name:");
        name = Console.ReadLine().ToUpper();
        while (name.Contains(" ") || name.Length > 10 || string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Your name cannot have spaces and cannot be more than 10 words, neither can it be empty!");
            name = Console.ReadLine().ToUpper();
        }

        Console.Clear();
        Console.WriteLine($"--- Today in the arena we have {name} VS the mighty {name2}! ---");
        Thread.Sleep(1000);
        Console.WriteLine("-------------------======================-------------------");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine($"{name}'s Health = {playerHealth}        {name2}'s Health = {player2Health}");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine($"{name}'s Max Damage = {playerMaxDamage}        {name2}'s Max Damage = {player2MaxDamage}");
        Thread.Sleep(1250);
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();

        while (playerHealth > 0 && player2Health > 0)
        {
            int playerDamage = Random.Shared.Next(playerMaxDamage);
            int player2Damage = Random.Shared.Next(player2MaxDamage);

            Console.Clear();
            Console.WriteLine($"---=== Round {round} ===---");
            Thread.Sleep(1000);

            playerHealth -= player2Damage;
            playerHealth = Math.Max(0, playerHealth);
            player2Health -= playerDamage;
            player2Health = Math.Max(0, player2Health);

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{name} did {playerDamage} damage to {name2}");
            Console.WriteLine($"{name2} did {player2Damage} damage to {name}");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("---------------=================---------------");
            Thread.Sleep(500);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{name} now has {playerHealth} health");
            Console.WriteLine($"{name2} now has {player2Health} health");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press ENTER to continue");

            round += 1;

            Console.ReadLine();
        }

        Console.ForegroundColor = ConsoleColor.DarkRed;

        Console.Clear();
        if (playerHealth <= 0 && player2Health <= 0)
        {
            Console.WriteLine("Both gladiators have died!");
            Thread.Sleep(2000);
        }
        else if (playerHealth <= 0)
        {
            Console.WriteLine($"{name} was killed by {name2}!");
            Thread.Sleep(2000);
        }
        else
        {
            Console.WriteLine($"{name2} was killed by {name}!");
            Thread.Sleep(2000);
        }
    }
    else if (choice == "4")
    {
        Console.Clear();
        Console.WriteLine("""
        This is how the GAME works:

        > Both players get 100 base Health
        > Then an additional randomized number between 0-100 is added to both players Health
        > Based on your opponents health, your damage will increase
        > Both player get 30 Max base Damage
        > Then, depending on the opponents added additional Health, you will recieve more Max damage
        > So the same number of added additional Health to the opponent, will be added to your Max Damage
        > Damage is also randomized each round (Between 0 and Max Damage)
        
        > Boss Battle is different though...
        > They also get 0 - 100 added Health, and damage depending on your added Health
        > However, on top of that, an added 100 Health and 100 Max Damage
        
        > Good Luck!

        Press ENTER to continue
        """);

        Console.ReadLine();
    }

        Console.ResetColor();
        Console.Clear();

        Console.WriteLine("Back to MENU?");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Yes? (y)");

        Console.ResetColor();
        Console.Write(" or ");

        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("No? (n)");

        Console.ResetColor();


    string answer = "";
    do
    {
        answer = Console.ReadLine().ToLower();

        if (answer != "y" && answer != "n")
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("You can only type: y or n!");
            Console.ResetColor();
        }
    } while (answer != "y" && answer != "n");
    
        if (answer == "y")
        {
            playAgain = true;
            Console.Clear();
            Console.WriteLine("Prepair yourself!");
            Thread.Sleep(2000);
        }
        else if (answer == "n")
        {
            playAgain = false;
            Console.Clear();
            Console.WriteLine("Okay, Goodbye!");
            Thread.Sleep(2000);
            Environment.Exit(0);
        }
}

