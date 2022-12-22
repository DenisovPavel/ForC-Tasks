
// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();

Console.Write("Введите первое число : ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число : ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число : ");
int d = Convert.ToInt32(Console.ReadLine());


if (a >= b && a >= d)
{
    Console.Write("Наибольшее число : " + a);
}
else if (a <= b && b >= d)
{
    Console.Write("Наибольшее число : " + b);
}
else
{
    Console.Write("Наибольшее число : " + d);
}
