using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Scrabble.Models;

namespace Scrabble.Tests
{
[TestClass]
public class ScrabbleTests
{

		[TestMethod]
		public void ScrabbleScore_ReturnZero_Int()
		{
			int result = Game.ScrabbleScore("");
			Assert.AreEqual(0, result);
		}

    [TestMethod]
    public void ScrabbleScore_ReturnOneForVowel_Int()
    {
      int result = Game.ScrabbleScore("aourt");
      Assert.AreEqual(3, result);
    }

		[TestMethod]
    public void ScrabbleScore_ReturnTwoForDG_Int()
    {
      int result = Game.ScrabbleScore("aourtdg");
      Assert.AreEqual(7, result);
    }
}
}
