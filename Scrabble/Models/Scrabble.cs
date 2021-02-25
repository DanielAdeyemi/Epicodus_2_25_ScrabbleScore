using System;
using System.Linq;

namespace Scrabble.Models
{
  public class Game
  {
    public static int ScrabbleScore(string word)
    {
      int sum = 0;
      char[] vowels = {'a', 'e', 'i', 'o', 'u'};
      for (int i = 0; i < word.Length; i++)
      {
        if (vowels.Contains(word[i]))
        {
          sum++;
        }
        else if (word[i].Equals('d') || word[i].Equals('g'))
        {
          sum+=2;
        }
      }
      return sum;
    }    
  }
}