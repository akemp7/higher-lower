using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Would you like to pick a number? (Yes/No)");
        string startGame = Console.ReadLine();
        if (startGame == "Yes" || startGame == "yes") 
        {
            GamePlay(0, 101);
        }
        else
        {
            Random random = new Random();
            int generatedNumber= random.Next(1, 101);
            ReverseGamePlay(generatedNumber);
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

    public static void ReverseGamePlay(int generatedNumber)
    {
    Console.WriteLine("Please guess my number.");
    string stringUserGuess = Console.ReadLine();
    bool checker = true;
    foreach (char c in stringUserGuess)
    {
        if (c < '0' || c > '9')
        {
            checker = false;
        }
    }
    if (checker)
    {
        int userGuess = int.Parse(stringUserGuess);
        if (userGuess == generatedNumber) 
        {
            Console.WriteLine("Congrats! You guessed my number");
        }
        else if (userGuess < generatedNumber)
        {
            Console.WriteLine("Higher");
            ReverseGamePlay(generatedNumber);
        }
        else if (userGuess > generatedNumber)
        {
            Console.WriteLine("Lower");
            ReverseGamePlay(generatedNumber);
            }
        else{
            Console.WriteLine("How did you get here?!"); 
            ReverseGamePlay(generatedNumber);
            }
    }
    else {
        Console.WriteLine("Please enter a number.");
        ReverseGamePlay(generatedNumber);
    }
    }
// private bool DigitChecker(string input) {
//     foreach (char c in input)
//     {
//         if (c < 0 || c > 9)
//         {
//             return false;
//         }
//     }
//     return true;
// }


}