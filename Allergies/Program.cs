using System;
using Allergies;

public class Program
{
  public static void Main()
  {
    AllergyScore allergen = new AllergyScore();
    int totalSum = 0;
    Console.WriteLine("Welcome to the Allergy Score Calculator");
    Console.WriteLine("Enter an allergen to get your score.");
    Console.WriteLine("---------------------------");
    while(true){
      Console.WriteLine("Enter an allergen, or type done to continue:");
      string response = Console.ReadLine().ToLower();
      if (response == "done") 
      {
        break;
      }
      else{
        totalSum += allergen.Score(response);
      }
    }

    Console.WriteLine("Your score is... " + totalSum);
    
  }
}