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

void FillArrya(int[,] arg)
{

    int r = arg.GetLength(0)-1;
    int c = arg.GetLength(1)-1;

    for (int i = 0; i < arg.GetLength(0); i++) // rows - строки
    {

        for (int j = 0; j < arg.GetLength(1); j++)  // columns - столбцы
        {
            arg[i, j] = i + 1 + j;
        }
    }
    for (int i =0; i < arg.GetLength(0)+1; i++)
    {
        if (i == r)
        {
            arg[r , c-i] +=r-i;
        }
    }
}

// void FillArrya1(int[,] arg)
// {

//     int r = arg.GetLength(0);
//     int c = arg.GetLength(1);
//     for (int i = 0; i < r; i++)
//     {
//         for (int j = 0; j < c; j++)
//         {
//             if (i == r - 1)
//             {
//                 arg[r - 1, c - 1 - j];
//             }
//         }
//     }


// }

Console.Write("Введите длину строки ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину столбца ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[row, colums];

FillArrya(arr);
PrintArrya(arr);
Console.WriteLine();
// FillArrya1(arr);
// PrintArrya(arr);
Console.WriteLine();
