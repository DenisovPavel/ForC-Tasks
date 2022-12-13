// Задача 50. Напишите программу, которая на вход принимает индексы элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1,1 -> 9
// 1,7 -> элемента с данными индексами в массиве нет


Console.Clear();


Console.WriteLine("Введите количество строк двумерного массива:");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива:");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве:");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве:");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = FillArray(rows, columns, min, max);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Введите индекс строки:");
int rowIndex = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс по столбцу:");
int colomnsIndex = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
ShowElement(array, rowIndex, colomnsIndex);

int[,] FillArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
{
    int[,] filledArray = new int[arrayRows, arrayColumns];
    Random random = new Random();

    for (int i = 0; i < arrayRows; i++)
    {
        for (int j = 0; j < arrayColumns; j++)
        {
            filledArray[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return filledArray;
}

void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}


void ShowElement(int[,] massiv, int indexRow, int indexColomn)
{
    int[,] massive = (int[,])massiv.Clone();

    if (indexRow > massiv.GetLength(1) - 1 && indexColomn > massiv.GetLength(0) - 1)
    {
        Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", massive[indexRow, indexColomn]);

    }
}




























// int[,] array = FillArray(rows, columns, min, max);

// PrintArray(array);

// int[,] FillArray(int arrayRows, int arrayColumns, int minValue, int maxValue)
// {
//     int[,] filledArray = new int[arrayRows, arrayColumns];
//     Random random = new Random();

//     for (int i = 0; i < arrayRows; i++)
//     {
//         for (int j = 0; j < arrayColumns; j++)
//         {
//             filledArray[i, j] = random.Next(minValue, maxValue + 1);
//         }
//     }
//     return filledArray;
// }

// void PrintArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             Console.Write(inputArray[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }
