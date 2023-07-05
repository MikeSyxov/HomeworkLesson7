// Задача 50.
//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//     17 -> такого числа в массиве нет

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
            System.Console.Write($"{array[i, j]}\t");
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

(int, int) FindNumber(int[,] arr, int number)    //картедж
{

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number) return (i, j);
        }
    }
    return (-1, -1);
}


int findNumber = ReadInt("Введите искомое число");
int[,] array = CreateArrD2(3, 4);

ShowArrayD2(array);

(int r, int c) = FindNumber(array, findNumber);
if (r == -1)
{
    System.Console.WriteLine($"Введенный число {findNumber} не найдено");
}
else
{
    System.Console.WriteLine($"Введенный число {findNumber} найдено, результат: {FindNumber(array, findNumber)}");
}