using System;
using System.Linq;

namespace Scrabble.Models
{
  public class Game
  {
    public static int ScrabbleScore(string word)
    {
      int sum = 0;
      char[] plusOne = {'a', 'e', 'i', 'o', 'u'};
      char[] plusThree = {'b', 'c', 'm', 'p'};
      char[] plusFour = {'f', 'h', 'v', 'w', 'y'};
      for (int i = 0; i < word.Length; i++)
      {
        if (plusOne.Contains(word[i]))
        {
          sum++;
        }
        else if (word[i].Equals('d') || word[i].Equals('g'))
        {
          sum+=2;
        }
        else if (plusThree.Contains(word[i]))
        {
          sum+=3;
        }
        else if(plusFour.Contains(word[i]))
        {
          sum+=4;
        }
        else if(word[i].Equals('k'))
        {
          sum+=5;
        }
      }
      return sum;
    }    
  }
}