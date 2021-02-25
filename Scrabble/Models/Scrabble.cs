using System;

namespace Scrabble.Models
{
  public class Game
  {
    public static int ScrabbleScore(string word)
    {
      int sum = 0;
      for (int i = 0; i < word.Length; i++)
      {
        if (word[i].Equals('a') || word[i].Equals('e') || word[i].Equals('o') || word[i].Equals('u') || word[i].Equals('i'))
        {
          sum++;
        }
      }
      return sum;
    }    
  }
}