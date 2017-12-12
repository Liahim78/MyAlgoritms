using System;
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
      var limit = Math.Sqrt(number);
      for (int i = 2; i <= limit; i++)
      {
        if (number % i == 0)
          return false;
      }
      return true;
    }
    
    public static List<long> GetSimples(long number)
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

    public static long FastPower (long value, long power, long modul = 0)
    {
      long result = 1;
      long current = value;
      while (power != 0)
      {
        if ((power & 1) != 0)
          result = modul==0? result*current: result*current % modul;
        power /= 2;
        current*=current;
      }
      return result;
    }

    //Нод
    public static long GCD(long firstNumber, long secondNumber)
    {
      if (secondNumber == 0)
        return firstNumber;
      else
        return GCD(secondNumber, firstNumber % secondNumber);
    }

    public static Dictionary<long,int> GetSimleDividers (long number)
    {
      var result = new Dictionary<long, int>();
      var i = 2;
      while (number > 1)
      {
        if (number % i++ != 0)
          continue;
        i--;
        if (result.ContainsKey(i))
          result[i]++;
        else
          result[i] = 1;
        number /= i;
      }
      return result;
    }
  }
}
