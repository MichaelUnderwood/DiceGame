using System;
using System.Runtime.CompilerServices;

internal class DiceSimulator
  //"DiceSimulator is the name of the program, can be named anything"
{
    static void Main()
        //scope (visibilty)
    {
        //starting the program
        Console.WriteLine("Welcome to the dice throwing simulator!");

        Console.Write("How many dice rolls would you like to simulate? ");
        int numberOfRolls = int.Parse(Console.ReadLine());

        DiceRoller diceRoller = new DiceRoller();
        int[] results = diceRoller.SimulateDiceRolls(numberOfRolls);

        PrintHistogram(results, numberOfRolls);

        Console.WriteLine("Thank you for using the dice throwing simulator!");
    }

    static void PrintHistogram(int[] results, int totalRolls)
    {
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {totalRolls}.");

        //loop to make the program (dice) roll become a percentage 
        for (int i = 2; i <= 12; i++)
        {
            int percentage = results[i] * 100 / totalRolls;
            Console.WriteLine($"{i}: {new string('*', percentage)}");
        }
    }
}

//contructors are 
