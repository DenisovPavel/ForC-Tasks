// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

string number3 = Convert.ToString(new Random().Next(1, 100000));
    Console.WriteLine($"Заданное число: {number3}");

    if (number3.Length < 3) Console.WriteLine("Третьей цифры нет");
    else
    {
        Console.WriteLine(number3[2]);
    }

  































