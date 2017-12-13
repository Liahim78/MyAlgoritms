namespace MyAlgoritms
{
  //Todo: Realize
  interface IDynamicArray<T>
  {
    T this[int index]
    {
      get;
      set;
    }

    void Add(T value);
  }
}
