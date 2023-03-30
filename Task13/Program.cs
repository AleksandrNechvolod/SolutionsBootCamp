// Задача 13: Напишите программу, которая 
// выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

///решение через строку???? только методы без вывода.

internal class Program
{
  static void Main(string[] args)
  {
    var c = new NumToArray(1234);
    var d = c[2];

    Console.WriteLine(d);
  }
}
public class NumToArray
{

  private readonly List<int> _values;

  public NumToArray()
  {
    _values = new List<int>();
  }
  public NumToArray(int i) : this()
  {
    while (i > 0)
    {
      _values.Insert(0, i % 10);
      i /= 10;
    }
  }

  public int this[int index]
  {
    get
    {
      if (_values.Count == 0)
      {
        throw new ArgumentException("Исходное число пустое!");
      }

      if (index > _values.Count - 1)
      {
        throw new IndexOutOfRangeException("");
      }

      return _values[index];
    }
  }
}
