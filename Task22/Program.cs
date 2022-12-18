using System;
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Clear();

Console.WriteLine("Введите количество строк двумерного массива");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов двумерного массива");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальное возможное значение в двумерном массиве");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальное возможное значение в двумерном массиве");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = FillArray(rows, columns, min, max);

PrintArray(array);
Console.WriteLine();

DoSort(rarray);
 Console.WriteLine("Отсортированный массив:\n ",String.Join(" ",array));


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

void DoSort(int[,] inputunsortArray)

{
    int[,] sortarray = new int[inputunsortArray.GetLength(0), inputunsortArray.GetLength(1)];

    for (int i = 0; i < sortarray.GetLength(0); i++) // с 1го эл до последнего;
    {
        for (int j = 0; j < sortarray.GetLength(1); j++)
        {
            for (int min = 0; min < sortarray.GetLength(1) - 1; min++)
            {


                if (sortarray[i, min] < sortarray[i, min + 1])  // следующий < текущего
                {
                    int temp = sortarray[i, min + 1];    //  времен.переменная = текущий
                    sortarray[i, min + 1] = sortarray[i, min]; // текущий = следующему
                    sortarray[i, min] = temp; // следующий = временной; 
                }
            }
        }
    }
}

