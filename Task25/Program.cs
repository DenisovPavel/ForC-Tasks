// // Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке 
// от M до N с помощью рекурсии.

// // M = 1; N = 5 -> 2, 4
// // M = 4; N = 8 -> 4, 6, 8

Console.Clear();

Console.WriteLine("Введите первое число:");
int minimum = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите второе число:");
int maximum = Convert.ToInt32(Console.ReadLine());

if (minimum > maximum)
{
    ShowEvenNumbers(maximum, minimum);
}
else
{
    ShowEvenNumbers(minimum, maximum);
}
void ShowEvenNumbers(int min, int max)
{
    if (min == max) return;
    if (min % 2 == 0)
    {
        Console.Write(min + "  ");
    }

    ShowEvenNumbers(min + 1, max);

}