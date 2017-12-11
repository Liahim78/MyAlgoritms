using System.Collections.Generic;

namespace MyAlgoritms
{
  static class MainAlgoritmsHelper
  {
    public static long FibonuchiNumber (int number)
    {
      long previous = 1;
      long current = 1;

      for (int i = 2; i < number; i++)
      {
        var temp = previous;
        previous = current;
        current = previous + temp;
      }

      return current;
    }

    public static bool IsSimple(long number)
    {
      return true;
    }

    public static List<long> GetSimple(long number)
    {
      List<long> allNumbers = new List<long>();
      List<long> simpleNumbers = new List<long>();
      for (int i = 2; i < number; i++)
        allNumbers.Add(i);
      while (allNumbers.Count != 0)
      {
        long current = allNumbers[0];
        simpleNumbers.Add(current);
        allNumbers.RemoveAll(item => item % current == 0);
      }
      return simpleNumbers;
    }
  }
}
