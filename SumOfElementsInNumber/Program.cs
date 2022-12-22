// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();
Console.Write("Введите число: ");
int number =  Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.Write("Введите корректное число! Ваше число ровняется нулю или имеет отрицательное значение! ");
}

else
{
    Console.Write($"Сумма цифр в числе {number} ровна : {getSumNumbers(number)}");
}

int getSumNumbers(int num)
{
    int last = 0;

    while (num > 0)
    {
        last = last + (num % 10); //last number
        num = num / 10; // сокращаем число для подбора след.last number
    }
    return last;
}
