using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgoritms
{
  class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        foreach (var item in MainAlgoritmsHelper.GetSimple(int.Parse(Console.ReadLine())))
        {
          Console.Write(item+ " ");
        }
        Console.WriteLine();
      }
    }
  }
}
