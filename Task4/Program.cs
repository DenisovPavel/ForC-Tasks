// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число : ");

int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
int num = 0;
while (i <= N)
{
    if (i % 2 == 0)
    {
        num = i;
        Console.Write($"{num}" + " ");
        i = i + 1;
    }
    if (i % 2 != 0)
    {
        i = i + 1;
    }
}




