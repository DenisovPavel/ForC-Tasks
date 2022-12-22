using System;
using System.ComponentModel;
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите цифру дня недели:");
int number = Convert.ToInt32(Console.ReadLine());

switch (number)
{
    case 1:
    case 2:
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Сегодня рабочий день!");
        break;
    case 6:
    case 7:
        Console.WriteLine("Сегодня выходной день!");
        break;
    default:
        Console.WriteLine("Цифра введена некорректно, повторите ввод!");
        break;
}