// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую
//  и последнюю строку массива.
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

void ChangeArray(int[,] arg) // Метода обмена 
{
    int N = arg.GetLength(0);
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        for (int j = 0; j < arg.GetLength(1); j++)
        {
            if (i == 0)
            {
                int h = arg[i, j];
                arg[i, j] = arg[N - 1, j];
                arg[N - 1, j] = h;
            }

        }

    }
}

void FillArryaMatrix(int[,] argMatrix)  // Метод заполнения матрицы рандомна
{
    for (int i = 0; i < argMatrix.GetLength(0); i++) // rows - строки
    {
        for (int j = 0; j < argMatrix.GetLength(1); j++)  // columns - столбцы
        {
            argMatrix[i, j] = new Random().Next(0, 10);
        }
    }
}
Console.Write("Введите длину строки ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину столбца ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[row, colums];

FillArryaMatrix(arr);
PrintArryaMatrix(arr);
ChangeArray(arr);

Console.WriteLine();
PrintArryaMatrix(arr);