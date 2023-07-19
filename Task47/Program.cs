// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Функция (Метод) ввода данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Функция (Метод) для заполнения 2D массива вещественными (doubl) числами
double[,] Gen2DArray(int row, int column)
{
    int i = 0; int j = 0;
    double[,] arr = new double[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = Math.Round(new Random().Next(0, 100) + new Random().NextDouble(), 2);
            j++;
        }
        i++;
    }
    return arr;
}

// Функция (Метод) вывода 2D  массива в консоль
void Print2DArr(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
            Console.ResetColor(); 
        }
        Console.WriteLine("");
    }
}

// 1. Получение данных от пользователя
int n = ReadData("Количество строк матрицы: ");
int m = ReadData("Количество столбцов матрицы: ");

// 2. Генерируем 2D  массив
double[,] arr2D = Gen2DArray(n, m);

// 3. Печатаем двумерный массив
Print2DArr(arr2D);