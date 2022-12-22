// Задача 68: Задайте значения M и N. Напишите программу, 
// которая найдёт наибольший общий делитель (НОД) этих чисел с помощью рекурсии.
// M = 28; N = 7 -> 7


Console.Clear();

Console.WriteLine("Введите первое число для нахождения делителя :");
int numberone = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число для нахождения делителя :");
int numbertwo = Convert.ToInt32(Console.ReadLine());

if (numberone > numbertwo)
{
    FindMaxDivisor(numberone, numbertwo);
}
else
{
    FindMaxDivisor(numbertwo, numberone);
}

int FindMaxDivisor(int numone, int numtwo)
{
    if (numone == numtwo)
    {
        return numone;
    }
    if (numone > numtwo)
    {
        int tmp = numone;
        numone = numtwo;
        numtwo = tmp;
    }
    return FindMaxDivisor(numone, numtwo - numone);
}

Console.WriteLine($"{FindMaxDivisor(numberone, numbertwo)}");