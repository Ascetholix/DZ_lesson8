Console.Clear();

// void PrintArray(int[,] arg)
// {
//   for (int i = 0; i < arg.GetLength(0); i++)
//   {
//     for (int j = 0; j < arg.GetLength(1); j++)
//     {
//       Console.Write($"{arg[i, j]} ");
//     }
//     Console.WriteLine();
//   }
// }

void FillArray(int[,] arg)
{
  for (int i = 0; i < arg.GetLength(0); i++)
  {
    for (int j = 0; j < arg.GetLength(1); j++)
    {
      if (i == 0) arg[i, j] = 1;
      if (j == i) arg[i, j] = 1;
      if (j > 0 && j < i) arg[i, j] = arg[i - 1, j - 1] + arg[i - 1, j]; 
    }
  }
}


string[,] ArrayPas(int[,] arg)
{
  string[,] arg1 = new string[arg.GetLength(0), arg.GetLength(1)];

  for (int i = 0; i < arg.GetLength(0); i++)
  {
    for (int j = 0; j < arg.GetLength(1); j++)
    {
      if (i != 0 && j != 0)
      {
        arg1[i, j] = Convert.ToString(arg[i, j]);
      }
    }
  }
  return arg1;
}
void PrintArrayPas(string[,] arg)
{
  for (int i = 0; i < arg.GetLength(0); i++)
  {
    for (int j = 0; j < arg.GetLength(1); j++)
    {
      if (arg[i, j] == "0") Console.Write($" ");
      else Console.Write($"\t{arg[i, j]} ");
    }
    Console.WriteLine();
  }
}

Console.Write("Введите длину строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину столбца: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[rows, cols];
FillArray(arr);
string[,] a = ArrayPas(arr);

PrintArrayPas(a);
