// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Функция (Метод) ввода данных с консоли
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}



// Функция (Метод) для заполнения 2D массива целыми (int) числами
int[,] Gen2DArrayInt(int row, int column)
{
    int i = 0; int j = 0;
    int[,] arr = new int[row, column];
    while (i < row)
    {
        j = 0;
        while (j < column)
        {
            arr[i, j] = new Random().Next(0, 99);
            j++;
        }
        i++;
    }
    return arr;
}

// Функция (Метод) поиска существования элемента в массиве и вывод результата в консоль
void SerchElemAndPrint(int[,] arr2D, int serchElem)
{
    bool elemSerch = false;
    for (int i = 0; i < arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < arr2D.GetLength(1); j++)
        {
            if (serchElem == arr2D[i, j])
            {
                elemSerch = true;
                Console.ForegroundColor = System.ConsoleColor.Red;
            }
            Console.Write(arr2D[i, j] + " \t");
            Console.ForegroundColor = System.ConsoleColor.White;
        }
        Console.WriteLine();
    }
    if (elemSerch == false)
    {
        Console.ForegroundColor = System.ConsoleColor.Red;
        Console.WriteLine("Элемент " + serchElem + " не найден");
    }
    Console.ForegroundColor = System.ConsoleColor.White;
}

// 1. Получение данных от пользователя
int column = ReadData("Количество столбцов матрицы: ");
int row = ReadData("Количество строк матрицы: ");
int findeNum = ReadData("Введите искомое число ");

// 2. Генерируем 2D  массив
int[,] arr2DArr = Gen2DArrayInt(column, row);

// 3. Ищем элемент в массиве и выводим результат в консоль
Console.WriteLine();
SerchElemAndPrint(arr2DArr, findeNum);

