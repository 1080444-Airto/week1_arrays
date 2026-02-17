
using Solution;
//using ToDo;

class MainClass
{
  static void Main()
  {
    DebugArray();
  }
  
  static void DebugArray()
  {
    var rand = new Random();
    var data = new int[] { 10, 1, 5, 7, 0, -3, 100, 5 };
    IArray1D<int> IArr1D = new Array1D<int>(data, data.Length - 1);
   
    var valueToFind = 7;
    var index = IArr1D.Find(valueToFind); //index>=0 if value was found otherwise -1
    Console.WriteLine($"{valueToFind} was found at index {index}");
    valueToFind = 5;
    var offset = 3;
    index = IArr1D.Find(valueToFind, offset);
    Console.WriteLine($"{valueToFind} after offset {offset} was found at index {index}");
  
    valueToFind = 7;
    offset = 4;
    index = IArr1D.Find(valueToFind, offset);
    //Instead of just looking value of index, apply conditionals 
    Console.WriteLine($"{valueToFind} after offset {offset} was {(index >= 0 ? "$found at index {index}" : "not found")}");
  
    var strings_ = new string[] { "10", "1", "5", "7", "0", "-3", "100", "45" };
    IArray1D<string> IArr1Dstring_ = new Array1D<string>(strings_, strings_.Length - 1);

    var valueToDelete = "-1";
    var test = IArr1Dstring_.Delete(valueToDelete);
    System.Console.WriteLine($"{valueToDelete} has been deleted: {test}, LastIndex: {IArr1Dstring_.LastIndex}\n{String.Join(":", IArr1Dstring_.data.Select(_ => _ == null ? "<NULL>" : _))}");

    valueToDelete = "10";
    test = IArr1Dstring_.Delete(valueToDelete);
    System.Console.WriteLine($"{valueToDelete} has been deleted: {test}, LastIndex: {IArr1Dstring_.LastIndex}\n{String.Join(":", IArr1Dstring_.data.Select(_ => _ == null ? "<NULL>" : _))}");

    valueToDelete = "5";
    test = IArr1Dstring_.Delete(valueToDelete);
    System.Console.WriteLine($"{valueToDelete} has been deleted: {test}, LastIndex: {IArr1Dstring_.LastIndex}\n{String.Join(":", IArr1Dstring_.data.Select(_ => _ == null ? "<NULL>" : _))}");

    valueToDelete = "7";
    test = IArr1Dstring_.Delete(valueToDelete);
    System.Console.WriteLine($"{valueToDelete} has been deleted: {test}, LastIndex: {IArr1Dstring_.LastIndex}\n{String.Join(":", IArr1Dstring_.data.Select(_ => _ == null ? "<NULL>" : _))}");

    var valueToAdd = "-1";
    test = IArr1Dstring_.Append(valueToAdd);
    System.Console.WriteLine($"{valueToAdd} has been added at the end: {test}, LastIndex: {IArr1Dstring_.LastIndex}\n{String.Join(":", IArr1Dstring_.data.Select(_ => _ == null ? "<NULL>" : _))}");

    valueToAdd = "6";
    var valueBefore = "-3";
    test = IArr1Dstring_.AddAfter(valueBefore, valueToAdd);
    System.Console.WriteLine($"{valueToAdd} has been added after {valueBefore}: {test}, LastIndex: {IArr1Dstring_.LastIndex}\n{String.Join(":", IArr1Dstring_.data.Select(_ => _ == null ? "<NULL>" : _))}");

    valueToAdd = "56";
    valueBefore = "6";
    test = IArr1Dstring_.AddAfter(valueBefore, valueToAdd);
    System.Console.WriteLine($"{valueToAdd} has been added after {valueBefore}: {test}, LastIndex: {IArr1Dstring_.LastIndex}\n{String.Join(":", IArr1Dstring_.data.Select(_ => _ == null ? "<NULL>" : _))}");


    var strings = new string[] { "10", "1", "5", "7", "0", "-3", "100", "5" };
    IArray1D<string> IArr1Dstring = new Array1D<string>(strings, strings.Length -1);
    var idx_i = rand.Next(0, strings.Length/2);
    var idx_j = rand.Next(strings.Length/2, strings.Length);
    var val_i = IArr1Dstring[idx_i];
    var val_j = IArr1Dstring[idx_j];
    Console.WriteLine($"strings[{idx_i}] = {val_i} strings[{idx_j}] = {val_j}");
    IArr1Dstring.Swap(idx_i, idx_j);
    val_i = IArr1Dstring[idx_i];
    val_j = IArr1Dstring[idx_j];
    Console.WriteLine($"After swap:\nstrings[{idx_i}] = {val_i};  strings[{idx_j}] = {val_j}");

    IArr1Dstring.data.ToList().ForEach(_ => Console.Write(_ + ", "));
    System.Console.WriteLine("\nReversed:");
    IArr1Dstring.Reverse();
    IArr1Dstring.data.ToList().ForEach(_ => Console.Write(_ + ", "));
    System.Console.WriteLine();

    strings = new string[] { "10!", "1!", "5!", "7!", "0!", "-3!", "100!" };
    IArr1Dstring = new Array1D<string>(strings, strings.Length - 1);

    IArr1Dstring.data.ToList().ForEach(_ => Console.Write(_ + ", "));
    System.Console.WriteLine("\nReversed:");
    IArr1Dstring.Reverse();
    IArr1Dstring.data.ToList().ForEach(_ => Console.Write(_ + ", "));
    System.Console.WriteLine();

    var arr = IArr1Dstring.CloneData();
    Console.WriteLine($"{(Enumerable.SequenceEqual(arr, IArr1Dstring.data) && arr != IArr1Dstring.data? "Ok" : "Wrong")}");
  
    INumArray1D<int> NumArr1D = new NumArray1D<int>(data);
    var sum = NumArr1D.Sum();
    var max = NumArr1D.Max();
    var min = NumArr1D.Min();
    var prod = NumArr1D.Product();
    var prod_ = NumArr1D.Product(false);
    System.Console.WriteLine();
  
  }
}