// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка
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
            arg[i, j] = new Random().Next(0, 10);
        }
    }
}

void SummaArray(int[,] arg)
{
    int sumRow = 0;
    int sumColumn = 0;
    int sum = 0;
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        sumColumn = 0;
        sumRow = 0;
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            sumRow += arg[i, j];
            sumColumn += arg[j, i];
            sum += arg[i, j];
        }
        Console.WriteLine($"Сумма {i + 1} строки {sumRow} и сумма {i + 1} колоны  {sumColumn}");
    }
    Console.WriteLine($"Обшая сумма элементов двумерного массива {sum}");
}

Console.Write("Введите длину строки ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину столбца ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[row, colums];

FillArrya(arr);
PrintArrya(arr);

SummaArray(arr);
