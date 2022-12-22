// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
Console.WriteLine("Задайте размер массива вещественных чисел: ");
int array = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное допустимое значение в массиве: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное допустимое значение в массиве: ");
int max = Convert.ToInt32(Console.ReadLine());


double[] size = fillArray(array, min, max);
Console.WriteLine($"Заданный массив: [ {string.Join(",", size)} ] - имеет разницу между максимальным и минимальным элементов массива [{getDifference(size)}]");

double getDifference(double[] array)
{
    double min = array[1];
    double max = array[0];
    double difference = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
        difference = max - min;
    }
    return difference;
}
double[] fillArray(int sizeArray, int minValue, int maxValue)
{
    Random rnd = new Random();
    double[] massiv = new double[sizeArray];
    for (int i = 0; i < massiv.Length; i++)
    {
        massiv[i] = rnd.NextDouble() * (maxValue - minValue) + minValue;
    }
    return massiv;
}