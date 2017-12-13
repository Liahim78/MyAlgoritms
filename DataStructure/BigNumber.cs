using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAlgoritms
{
  //Todo: Big Number
  struct BigNumber
  {
    //Todo: Make my List
    List<int> current;
    

    public BigNumber(int number)
    {
      current = new List<int>();
    }

    #region operators
    //Todo: reailze +
    public static BigNumber operator +(BigNumber firstOperand, BigNumber secondOperand)
    {
      return firstOperand;
    }

    //Todo: reailze -
    public static BigNumber operator -(BigNumber firstOperand, BigNumber secondOperand)
    {
      return firstOperand;
    }

    //Todo: reailze *
    public static BigNumber operator *(BigNumber firstOperand, BigNumber secondOperand)
    {
      return firstOperand;
    }

    //Todo: reailze /
    public static BigNumber operator /(BigNumber firstOperand, BigNumber secondOperand)
    {
      return firstOperand;
    }

    //Todo: reailze ==
    public static bool operator ==(BigNumber firstOperand, BigNumber secondOperand)
    {
      return true;
    }

    //Todo: reailze !=
    public static bool operator !=(BigNumber firstOperand, BigNumber secondOperand)
    {
      return false;
    }

    //Todo: realize long
    public static implicit operator BigNumber(long bigNumber)
    {
      return new BigNumber(0);
    }
    #endregion

    #region overrides
    public override string ToString()
    {
      return ""; //Todo: realize method ToString
    }

    //Todo: realize equals
    public override bool Equals(object obj)
    {
      if (!(obj is BigNumber))
      {
        return false;
      }

      var number = (BigNumber)obj;
      return EqualityComparer<List<int>>.Default.Equals(current, number.current);
    }

    //Todo: realize getHashCode
    public override int GetHashCode()
    {
      var hashCode = -647644198;
      hashCode = hashCode * -1521134295 + base.GetHashCode();
      hashCode = hashCode * -1521134295 + EqualityComparer<List<int>>.Default.GetHashCode(current);
      return hashCode;
    }
    #endregion 
  }
}
