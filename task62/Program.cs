// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
Console.Clear();

void PrintArrya(int[,] arg)   // Метод вывода матрицы
{
  for (int i = 0; i < arg.GetLength(0); i++) // rows - строки
  {
    for (int j = 0; j < arg.GetLength(1); j++)  // columns - столбцы
    {
      Console.Write($" {arg[i, j]} ");
    }
    Console.WriteLine();
  }
}

int[,] FillArrya(int[,] arg)
{
  int[] mas = new int[arg.GetLength(0) * arg.GetLength(1)];
  int N = arg.GetLength(0);
  int L = arg.GetLength(1);
  int i = 0;
  int j = 0;
  for (int h = 1; h < N + L; h++)
  {

    int a = 0;
    if (i == 0 && j < N)
    {
      arg[i, j] = h;
      j++;
    }
    if (j + 1 == L && i < L)
    {
      a = h + 1;
      arg[i, j] = a;
      i++;
    }
  }
//   int l = (N - 1) - 1;
//   int k = (L - 1) - 1;

//   for (int h = 0; h < (N - 1) + (L - 1); h++)
//   {

//     if (l == N - 1 && k < N )
//     {
//       arg[l, k] = h;
//       k++;
//     }

//   }
  return arg;
}

// Console.Write("Введите длину строки ");
// int row = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите длину столбца ");
// int colums = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[4, 4];

PrintArrya(FillArrya(arr));

