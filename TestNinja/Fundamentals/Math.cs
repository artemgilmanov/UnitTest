using System.Collections.Generic;

namespace TestNinja.Fundamentals
{
  public class Math
  {
    public List<int> FibonacciNumbers => new List<int> { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55 };

    public int Add(int a, int b)
    {
      return a + b;
    }

    public double AddDouble(double a, double b)
    {
      return a + b;
    }

    public int Max(int a, int b)
    {
      return (a > b) ? a : b;
    }

    public IEnumerable<int> GetOddNumbers(int limit)
    {
      for (var i = 0; i <= limit; i++)
        if (i % 2 != 0)
          yield return i;
    }
  }
}