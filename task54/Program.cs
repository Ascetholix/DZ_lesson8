﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

Console.Write("Введите длину строки ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину столбца ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[row, colums];

FillArrya(arr);
PrintArrya(arr);