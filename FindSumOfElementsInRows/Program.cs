// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

FindSmallSumRows(array);

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

void FindSmallSumRows(int[,] inputarray)
{
    int[,] outerArray = new int[inputarray.GetLength(0), inputarray.GetLength(1)];
    int count = 0; //счетчик;
    for (int i = 0; i < outerArray.GetLength(0); i++)
    {
        int minRow = 0; // мин строка;
        int sum = 0; // сумма элементов строки;

        for (int j = 0; j < outerArray.GetLength(1); j++)
        {
            sum += outerArray[i, j]; // + элемент;

            if (sum <= minRow)
            {
                sum = minRow;  
                count = i;
            }
        }
    }
Console.Write($" Строка с минимальной суммой элементов равна {count} строке. ");
}

