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
}
}
