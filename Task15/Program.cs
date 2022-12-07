// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();

Console.Clear();

Console.WriteLine("Введите размерность массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(size, min, max);

Console.WriteLine($"Cумма элементов массива: [ {string.Join(", ", array)} ] , стоящих на нечётных позициях ровна : [ {getSumNotEvenPosition(array)} ]");
int[] FillArray(int sizeArray, int minValue, int maxValue)
{
    Random random = new Random();
    int[] resultArray = new int[sizeArray];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = random.Next(minValue, maxValue + 1);
    }
    return resultArray;
}



int getSumNotEvenPosition(int[] arraySize)
{
    int result = 0;
    for (int i = 1; i < arraySize.Length; i+=2)
    {
       if (arraySize[i] % 2 != 0);
        result = result + arraySize[i];
    }
    return result;
}
