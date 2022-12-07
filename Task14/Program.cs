// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


Console.Clear();

Console.WriteLine("Введите размерность массива");
int size = Convert.ToInt32(Console.ReadLine());                               

Console.WriteLine("Введите минимальное допустимое значение в массиве от 100");   
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Введите максимальное допустимое значение в массиве до 999");   
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[] array = FillArray(size, min, max);


Console.WriteLine(IsCorrectNumbers(min, max) ? $" Массив [ {string.Join(", ", array)} ] \n Колличество четных трехзначных числе в массиве   [ {string.Join(", ", getEvenNumber(array))} ]" : "Введенные числа не допустимы");




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


int getEvenNumber(int[] inputArray)
{
    int count = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (inputArray[i] % 2 == 0)

            count++;

    }
    return count;

}


bool IsCorrectNumbers(int minElement, int maxElement)
{
    if (minElement >= 100 & maxElement <= 999)
        return true;
    else return false;
}
