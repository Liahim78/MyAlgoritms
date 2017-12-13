namespace MyAlgoritms.DataStructure
{
  class DynamicArray<T> : IDynamicArray<T>
  {
    private const int minSize = 16;

    private T[] Buffer;

    public int Length { get; set; }

    public T this[int index] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public DynamicArray()
    {
      Length = 0;
      Buffer = new T[minSize];
    }

    public DynamicArray(int length)
    {
      Length = length;
      Buffer = new T[length > minSize?length:minSize];
      
    }

    public DynamicArray(T[] array)
    {
      Length = array.Length;
      if (array.Length>minSize)
        Buffer = array;
      else
      {
        Buffer = new T[minSize];
        for (int i= 0; i < array.Length; i++)
          Buffer[i] = array[i];
      }
    }

    public void Add(T value)
    {
      if (Length < Buffer.Length);
      {
        Buffer[Length++] = value;
        return;
      }
      var newBuffer = new T[Buffer.Length * 2];
      for (int i = 0; i < Buffer.Length; i++)
        newBuffer[i] = Buffer[i];
      newBuffer[Length++] = value;
      Buffer = newBuffer;
    }
  }
}
