//  Создание и вывод массива
// int[] array = new int[5];
// for (int i = 0; i < 5; i++)
//   array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// Console.WriteLine(array[3]);
// // Сложность алгоритма O(1)

// нахождение суммы элементов массива
// int n = 5;
// int[] array = new int[n];
// for (int i = 0; i < n; i++)
//   array[i] = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("[" + string.Join(", ", array) + "]");
// // [4, 5, 3, 1, 2]
// // O(n)
// // [1, 2, 3, 4, 5] - O(n * log n)
// // ((5 + 1) / 2) * 5 - 0(1)
// // n < n * log(n) + 1

// //  а лучше решить вот так
// int sum = 0;
// for (int i = 0; i < n; i++)
//   sum += array[i];
// Console.WriteLine(sum);
// // O(n)


int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
  for (int j = 1; j <= n; j++)
  {
    Console.Write(i * j);
    Console.Write("\t");
  }
  Console.WriteLine();
}
// O(n*2)
