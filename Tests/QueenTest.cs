using Xunit;
using System;
using System.Collections.Generic;

namespace QueenAttack
{
  // public class TranslatorTest : IDisposable
  public class TranslatorTest
  {
    [Fact]
    public void TestIfQueenCanAttackColumns()
    {
      //Arrange
      int userOneX = 4;
      int userOneY = 6;
      //Act
      var newQueen = new Queen(userOneX, userOneY);
      //Assert
      Assert.Equal(true, newQueen.CanAttack(4, 7));
    }
    [Fact]
    public void TestIfQueenCanAttackRows()
    {
      //Arrange
      int userOneX = 3;
      int userOneY = 6;
      //Act
      var newQueen = new Queen(userOneX, userOneY);
      //Assert
      Assert.Equal(true, newQueen.CanAttack(4, 6));
    }
    [Fact]
    public void TestIfQueenCanAttackDiag()
    {
      //Arrange
      int userOneX = 3;
      int userOneY = 2;
      //Act
      var newQueen = new Queen(userOneX, userOneY);
      //Assert
      Assert.Equal(true, newQueen.CanAttack(6, 5));
    }
  }
}
