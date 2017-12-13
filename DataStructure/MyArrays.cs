namespace MyAlgoritms
{
  static class MyArrays
  {
    public static long GetIndex(this long[] myArray, long value)
    {
      for (int i = 0; i < myArray.Length; i++)
      {
        if (myArray[i] == value)
          return i;
      }
      return -1;
    }

    public static bool Contains(this long[] myArray, long value)
    {
      return myArray.GetIndex(value)!=-1;
    }

    public static long GetFirstMaxIndex (this long[] myArray)
    {
      var maxIndex = 0;
      for (int i = 1 ; i < myArray.Length; i++)
      {
        if (myArray[i] > myArray[maxIndex])
          maxIndex = i;
      }
      return maxIndex;
    }

    public static long GetFirstMax (this long[] myArray)
    {
      return myArray[myArray.GetFirstMaxIndex()];
    }

    public static long BinarySearch(this long[] myArray, long value, long first = 0, long? second = null)
    {
      if (!second.HasValue)
        second = myArray.Length - 1;
      if (first >= second)
        return myArray[first] == value ? first : -1;
      var mid = first + second.Value / 2;
      if (myArray[mid] > value)
        return myArray.BinarySearch(value, first, mid - 1);
      else if (myArray[mid] < value)
        return myArray.BinarySearch(value, mid + 1, second);
      else
        return mid;
    }

    public static long BinarySearchIterative(this long[] myArray, long value)
    {
      long first = 0;
      long last = myArray.Length - 1;
      while (first + 1 < last)
      {
        var mid = (first + last) / 2;
        if (value <= myArray[mid])
          last = mid;
        else
          first = mid;
      }
      return value - myArray[first] <= myArray[last] - value ? first : last;
    }
  }
}
