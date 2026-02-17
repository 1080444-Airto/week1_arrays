
using System.Numerics;

public interface INumArray1D<T>: IArray1D<T> where T:INumber<T>{
    T? Sum();
    T? Min();
    T? Max();
    T? Product(bool IgnoreZeros=true);
}