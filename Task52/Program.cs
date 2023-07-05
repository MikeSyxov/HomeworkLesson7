// Задача 52.
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//     Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArrD2(int rows, int cols)
{
    int[,] arrayD2 = new int[rows, cols];

    for (int i = 0; i < arrayD2.GetLength(0); i++)
    {
        for (int j = 0; j < arrayD2.GetLength(1); j++)
        {
            arrayD2[i, j] = new Random().Next(1, 9); 
        }
    }
    return arrayD2;
}

void ShowArrayD2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:F1}\t");
        }
        System.Console.WriteLine();
    }
}
int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    string inputedString = Console.ReadLine();
    if (int.TryParse(inputedString, out int convertedInt))
    {
        return convertedInt;
    }

    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int rows = ReadInt("Введите число строк");
int columns = ReadInt("Введите число столбцов");
ShowArrayD2(CreateArrD2(rows, columns));