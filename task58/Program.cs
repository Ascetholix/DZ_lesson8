// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Console.Clear();

void PrintArrya(int[,] arg)   // Метод вывода матрицы
{
    for (int i = 0; i < arg.GetLength(0); i++) // rows - строки
    {
        for (int j = 0; j < arg.GetLength(1); j++)  // columns - столбцы
        {
            Console.Write($"{arg[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArrya(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++) // rows - строки
    {
        for (int j = 0; j < arg.GetLength(1); j++)  // columns - столбцы
        {
            arg[i, j] = new Random().Next(1, 10);
        }
    }
}

void DerivativeArrya(int[,] arg, int[,] arg1)
{
    int[,] result = new int[arg.GetLength(0), arg1.GetLength(0)]; // Длина равно для arg и arg1

    if (arg.GetLength(1) == arg1.GetLength(0)) // если строка arg равно стольбцам arg1
    {
        for (int i = 0; i < arg.GetLength(0); i++) // rows - строки
        {
            for (int j = 0; j < arg1.GetLength(1); j++)  // columns - столбцы
            {
                for (int l = 0; l < result.GetLength(0); l++)
                {
                    result[i, j] += arg[i, l] * arg1[l, j];
                }
                Console.Write($"{result[i, j]} ");
            }
            Console.WriteLine();
        }
    }
    else Console.WriteLine("Столбцы  не равны строкам");

}



Console.Write("Введите длину строки ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину столбца ");
int colums = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второй строки ");
int row1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второго столбца ");
int colums1 = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[row, colums];
int[,] arrya = new int[row1, colums1];

FillArrya(arr);
FillArrya(arrya);

PrintArrya(arr);
Console.WriteLine();
PrintArrya(arrya);
Console.WriteLine("Приозведение матриц ");
DerivativeArrya(arr, arrya);