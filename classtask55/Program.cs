// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
//  В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Console.Clear();

void PrintArryaMatrix(int[,] argMatrix)   // Метод вывода матрицы
{
    for (int i = 0; i < argMatrix.GetLength(0); i++) // rows - строки
    {
        for (int j = 0; j < argMatrix.GetLength(1); j++)  // columns - столбцы
        {
            Console.Write($"{argMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArryaMatrix(int[,] argMatrix)
{
    for (int i = 0; i < argMatrix.GetLength(0); i++) // rows - строки
    {
        for (int j = 0; j < argMatrix.GetLength(1); j++)  // columns - столбцы
        {
            argMatrix[i, j] = new Random().Next(0, 10);
        }
    }
}

void ChangeArray(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            Console.Write($"{arg[j, i]} ");

        }
        Console.WriteLine();
    }
}
Console.Write("Введите длину строки ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину столбца ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[row, colums];

FillArryaMatrix(arr);
PrintArryaMatrix(arr);
Console.WriteLine();
if (row == colums) ChangeArray(arr);
else Console.WriteLine("Нельзя пемнять строки и стольбцы");
