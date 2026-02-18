using System.Numerics;

namespace Solution;

public class NumArray1D<T> : Array1D<T>, INumArray1D<T> 
    where T : IComparable<T>, INumber<T>
{
    public NumArray1D(int size = 10) : base(size) { }

    public NumArray1D(T[] data) : base(data, data.Length - 1) { }

    public T? Sum()
    {
        if (LastIndex < 0)
            return default;

        T sum = T.Zero;

        for (int i = 0; i <= LastIndex; i++)
        {
            sum += data[i];
        }

        return sum;
    }

    public T? Min()
    {
        if (LastIndex < 0)
            return default;

        T min = data[0];

        for (int i = 1; i <= LastIndex; i++)
        {
            if (data[i].CompareTo(min) < 0)
                min = data[i];
        }

        return min;
    }

    public T? Max()
    {
        if (LastIndex < 0)
            return default;

        T max = data[0];

        for (int i = 1; i <= LastIndex; i++)
        {
            if (data[i].CompareTo(max) > 0)
                max = data[i];
        }

        return max;
    }

    public T? Product(bool IgnoreZeros = true)
    {
        if (LastIndex < 0)
            return default;

        T product = T.One;
        bool hasValidElement = false;

        for (int i = 0; i <= LastIndex; i++)
        {
            if (IgnoreZeros && data[i] == T.Zero)
                continue;

            product *= data[i];
            hasValidElement = true;
        }

        if (!hasValidElement)
            return default;

        return product;
    }
}