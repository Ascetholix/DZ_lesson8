// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
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
        int count = 1;
        int j = 0;
        int b = arg[i, j];
        for (j = 0; j < arg.GetLength(1); j++)
        {

            if (b == arg[i, j] && i != j)
            {
                b = arg[i, j];
                count++;

            }
            // Console.WriteLine($"Число {arg[i, j]} в строке {i + 1} втречаеться {count} раз");

        }
        Console.WriteLine($"Число {arg[i, j]} в строке {i + 1} втречаеться {count} раз");
        // Console.WriteLine();
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