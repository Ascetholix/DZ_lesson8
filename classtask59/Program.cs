// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
//  на пересечении которых расположен наименьший элемент массива.
// Например, 
// задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент -
//  1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7
// треугольника
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

int[,] DaleteArryaMatrix(int[,] arg)
{
    int min = arg[arg.GetLength(0) - 1, arg.GetLength(1) - 1];   // Минимум элемента массива
    int inRowMin = 0;                                              // Мини индекс строки 
    int inColumMin = 0;                                             // Мини индекс  стольбца

    int[,] arg1 = new int[arg.GetLength(0) - 1, arg.GetLength(1) - 1];  // новый  массив размер -1 размера задаваемого массив

    for (int i = 0; i < arg.GetLength(0); i++) // rows - строки
    {
        for (int k = 0; k < arg.GetLength(1); k++)  // columns - столбцы
        {
            if (min > arg[i, k])
            {
                min = arg[i, k];
                inRowMin = i;
                inColumMin = k;
            }
        }
        
    }
    for (int i = 0; i < arg1.GetLength(0); i++)
    {
        for (int j = 0; j < arg1.GetLength(1); j++)
        {
            if (i != inRowMin && j != inColumMin)
            {
                arg1[i, j] = arg[i, j];
            }
        }
    }
    return arg1;
}

Console.Write("Введите длину строки ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину столбца ");
int colums = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[row, colums];

FillArryaMatrix(arr);
PrintArryaMatrix(arr);
Console.WriteLine();
// DaleteArryaMatrix(arr);
PrintArryaMatrix(DaleteArryaMatrix(arr));