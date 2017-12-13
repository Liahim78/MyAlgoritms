using System;
using System.Linq;

namespace MyAlgoritms
{
  class Program
  {
    static void Main(string[] args)
    {
      var aLength = long.Parse(Console.ReadLine());
      var a = Console.ReadLine().Split(' ').Select(item => long.Parse(item)).ToArray();
      var bLength = long.Parse(Console.ReadLine());
      var b = Console.ReadLine().Split(' ').Select(item => long.Parse(item)).ToArray();
      foreach (var item in b)
        Console.Write("{0} ",BinarySearch(a,item));
    }

    public static long BinarySearch(long[] myArray, long value)
    {
      long first = 0;
      long last = myArray.Length-1;
      while (first+1 < last)
      {
        var mid = (first + last) / 2;
        if (value <= myArray[mid])
          last = mid;
        else
          first = mid;
      }
      return value-myArray[first]<=myArray[last]-value?first:last;
    }
  }
}
