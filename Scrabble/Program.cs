using System;
using Scrabble.Models;

namespace Scrabble
{
class Program
{
		static void Main(string[] args)
		{
			Console.WriteLine(Game.ScrabbleScore(args[0]));

		}
}
}
