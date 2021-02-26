using System;
using Scrabble.Models;

namespace Scrabble
{
class Program
{
		static void Main(string[] args)
		{
			if (args.Length !=1) 
			{
				Console.WriteLine("You need to pass 1 string after _dotnet run_");
			}
			else
			{
				Console.WriteLine(Game.ScrabbleScore(args[0]));
			}

		}
}
}
