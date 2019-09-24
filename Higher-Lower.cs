using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Would you like to play/lower game? (Yes/No)");
        string startGame = Console.ReadLine();
        if (startGame == "Yes" || startGame == "yes") 
        {
            GamePlay(0, 101);
        }
 
    }

    public static void GamePlay(int min, int max) {
        int guess = (min + max)/2;
        Console.WriteLine("Is your number higher or lower than " + guess + "? (Higher/Lower/Correct");
        string answer = Console.ReadLine();
        
        if (answer == "Correct" || answer == "correct")
        {
            Console.WriteLine("Game Over. The computer has guessed your number.");
        }
        else if (min == max)
        {
            Console.WriteLine("min is equal to max. You wouldn't be cheating, would you?");
        }
        else if (answer == "higher" || answer == "Higher")
        {
            GamePlay(guess, max);
        }
        else if (answer == "lower" || answer == "Lower")
        {
            GamePlay(min, guess);
        }
        else
        {
            Console.WriteLine("Invalid input. Try again, sucka!");
            GamePlay(min, max);
        }
    }
}