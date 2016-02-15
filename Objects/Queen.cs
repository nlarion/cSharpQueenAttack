using System;
using System.Collections.Generic;

namespace QueenAttack
{
  public class Queen
  {
    private int _x1;
    private int _y1;

    public Queen(int x1, int y1)
    {
      _x1 = x1;
      _y1 = y1;
    }

    public bool CanAttack(int x2, int y2)
    {
      if (_x1 == x2)
      {
        return true;
      }
      else if (_y1 == y2) {
        return true;
      }
      else if (Math.Abs(_x1 - x2) == Math.Abs(_y1 - y2)) {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
