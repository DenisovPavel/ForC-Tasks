// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
//  натуральных элементов в промежутке от M до N с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Clear();
Console.WriteLine("Введите первое число:");
int minimum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int maximum = Convert.ToInt32(Console.ReadLine());

if (minimum > maximum)
{
    Console.WriteLine("Некоректный ввод чисел! Первое число не может быть больше второго!");
}

else
{
    int FindSumElements(int min, int max)
    {
        if (min == max) return min;
        return min + FindSumElements(min + 1, max);
    }

    Console.WriteLine($"Сумма цифр от {minimum} до {maximum} ровна {FindSumElements(minimum, maximum)}");

}



