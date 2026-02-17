namespace Solution;
public class Array1D<T> : IArray1D<T> where T : IEquatable<T>
{
    public T[] data { get => _data; set => _data = value;}

    protected T[] _data = null!;
    protected int _index;
    
    public Array1D(int size = 10) { 
        _data = new T[size];
        _index = -1;
    }

    public Array1D(T[] data, int lastIndex) { 
        //Shallow or deep copy here
        _data = data; //Shallow copy
        _index = lastIndex;
    }

    public int Length => _data.Length;
    public int LastIndex => _index;


    public bool Append(T key)
    {
        if (_index == Length - 1) return false;

        _index++;
        _data[_index] = key;
        return true;
    }

    public bool AddAfter(T keyBefore, T keyToAdd)
    {
        int pos = Find(keyBefore);

        if (pos == -1) return false;

        if (_index == Length - 1) return false;

        Shift(pos + 1, true);
        _data[pos + 1] = keyToAdd;
        _index++;

        return true;
    }

    public bool Delete(T key)
    {
        int pos = Find(key);

        if (pos == -1) return false;

        Shift(pos, false);
        _index--;

        return true;
    }

    public int Find(T Item, int startIndex = 0)
    {
        if (startIndex < 0) startIndex = 0;

        for (int i = startIndex; i <= _index; i++)
        {
            if (_data[i].Equals(Item)) return i;
        }

        return -1;
    }

    public void Swap(int i, int j)
    {
        if (i < 0 || j < 0 || i > _index || j > _index) return;

        T temp = _data[i];
        _data[i] = _data[j];
        _data[j] = temp;
    }

    public void Reverse()
    {
        int left = 0;
        int right = _index;

        while (left < right)
        {
            Swap(left, right);
            left++;
            right--;
        }
    }

    public T[] CloneData()
    {
        if (_index < 0) return new T[0];

        T[] copy = new T[_index + 1];

        for (int i = 0; i <= _index; i++)
        {
            copy[i] = _data[i];
        }

        return copy;
    }

    public void Shift(int i, bool right = true)
    {
        if (i < 0 || i > _index + 1) return;

        if (right)
        {
            if (_index == Length - 1) return;

            for (int j = _index; j >= i; j--)
            {
                _data[j + 1] = _data[j];
            }
        }
        else
        {
            for (int j = i; j < _index; j++)
            {
                _data[j] = _data[j + 1];
            }
        }
    }
}