
// Напишите программу, которая принимает на вход 2 числа (N,M) 
// и выдаёт таблицу кубов чисел от N до M.

// 2,3 -> 8, 27

Console.Clear();
Console.Write("Введите первое число: ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberM = Convert.ToInt32(Console.ReadLine());

int count = 0;

if (numberN > numberM)
{
    Console.WriteLine($"Ошибка ввода чисел! Число {numberN} не должно быть больше числа {numberM}! Повторите ввод!");
}
while (numberN < numberM & count <= numberM)
{
    int vkube = numberN * numberN * numberN;
    Console.WriteLine($"Число {numberN} в кубической степени - {vkube}");
    numberN++;
    count++;
  
}

