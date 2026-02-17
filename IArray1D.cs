

public interface IArray1D<T> where T : IEquatable<T>//IComparable<T>  //INumber //.net7
{
    public T[] data{get; set;}

    public T this[int idx]
    {
        get => data[idx];
    }
    
    public int Length { get; }
    public int LastIndex { get; }  

    public void Shift(int i, bool right = true);

    public bool Append(T key);

    public bool AddAfter(T keyBefore, T keyToAdd);

    int Find(T Item, int startIndex=0);

    public bool Delete(T key);

    public void Swap(int i, int j);

    public void Reverse();

    public T[] CloneData();

}
