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

      [TestMethod]
      public void AddPoints_ReturnSum_Int()
      {
        Scrabble testScrabble = new Scrabble();
        Assert.AreEqual(20, testScrabble.Adding("qz"));
      }

      [TestMethod]
      public void ValidateTheString()
      {
        Scrabble testScrabble = new Scrabble();
        Assert.AreEqual(false, testScrabble.Validate("Abc123"));
      }
  }
}
