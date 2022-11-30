// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.Write("Введите пятизначное число : ");
int number = Convert.ToInt32(Console.ReadLine());
int element0, element1, element2;

element0 = number / 10000;
element1 = number % 10;
element2 = number / 1000 % 10;


if (number < 100000 & number >= 10000)
{
    if (element0 != element1 & element2 != element1 - 1)
    {
        Console.WriteLine($"Введеное пятизначное число: {number} не является палиндромом!");

    }
    else
    {
        Console.WriteLine($"Введеное пятизначное число: {number}  является палиндромом!");
    }
}
else
{
    Console.WriteLine($"Некорректный ввод пятизначного числа: {number} !!!");
}

