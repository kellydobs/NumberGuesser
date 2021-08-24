using System;

namespace NumberGuesser
{
  class Program
  {
    static void Main(string[] args)
    {
      ShowGreeting();

      int low = 1;
      int high = 1024;
      int guess = 0;
      string userResponse = "";


      while (userResponse != "correct")
      {
      //computer makes a guess
      // low = 1 and high = 3.. middle is (1+3)/2 = 2
      // guess = 512
      
      guess = (low + high)/2;
      userResponse = PromptGuessCorrectness(guess);

      //We should check for the validity of the userResponse
      if (!ValidateResponse(userResponse)){
          Console.WriteLine("Invalid response, exiting the game...");
          return;
      };
      
      
      
      //If the answer is incorrect, we want to redefine low or high 
      //to make a better subsequent guess

      if (userResponse == "lower")
      {
        high = guess;
      } 
      
      else if (userResponse == "higher")
      {
        low = guess;
      }

      //computer loops until correct
      }

      BragWhenCorrect();
   }


   static void ShowGreeting(){
      Console.WriteLine("Welcome to C#");
      Console.WriteLine("Think of a number between 1 and 1024.");
      Console.WriteLine("I will try to guess the number.....");

   }


    static string PromptGuessCorrectness(int guess)
    {
      Console.WriteLine($"Your Number is {guess}");


      //computer prompts for a response

      Console.WriteLine("Is your number HIGHER, LOWER, or CORRECT?");
      return Console.ReadLine().ToLower();

    }

    static bool ValidateResponse(string userResponse)
    {
      if (userResponse == "correct" || userResponse == "higher" || userResponse == "lower")
      {
      
        return true;
      }

      else 
      {
        return false;
        }
    }

    static void BragWhenCorrect()
{
  Console.WriteLine("MUAHAHAHAA I AM UNDEFEATED!");

}
  }

}
