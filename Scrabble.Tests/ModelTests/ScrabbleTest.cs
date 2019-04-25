using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble;

namespace Scrabble.Tests
{
  [TestClass]
  public class ScrabbleTest
  {
    [TestMethod]
    public void IsScrabbleCheckIfString_True()
    {
      //Act
    Scrabble testScrabble = new Scrabble();
      //Assert
      Assert.AreEqual(true, testScrabble.IsScrabble("apple"));
    }
  }
}
