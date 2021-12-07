using System;
using System.Collections.Generic;
namespace Allergies
{
  
  public class AllergyScore
  {
    
    public int Score(string allergenScore)
    {
      Dictionary <string, int> myAllergies = new Dictionary<string, int>();
      
      // add key, value pairs to Dictionary
      myAllergies.Add("eggs", 1);
      myAllergies.Add("peanuts", 2);
      myAllergies.Add("shellfish", 4);
      myAllergies.Add("strawberries", 8);
      myAllergies.Add("tomatoes", 16);
      myAllergies.Add("chocolate", 32);
      myAllergies.Add("pollen", 64);
      myAllergies.Add("cats", 128);

      if(myAllergies.ContainsKey(allergenScore)){
        return myAllergies[allergenScore];
      } 
      else{
        return 0;
      }
    }
  }
};