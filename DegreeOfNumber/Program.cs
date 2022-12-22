// Задача 25: Напишите цикл, который принимает на вход
//  два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Напишите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Напишите второе число (натуральную степень первого): ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (getRightNumber(firstNumber,secondNumber))
{
    Console.Write("Отрицательное число! Повторите ввод! ");

}
else
{
    Console.Write($"Число {firstNumber} в натуральной степени {secondNumber} = {getDegreeOfFirstNumber(firstNumber, secondNumber)}");
}

int getDegreeOfFirstNumber(int num1, int num2)
{
int degree = 1;
    for (int i = 1; i <= num2; i++)
    {

     degree = degree * num1;
     
    }
    return degree;
}

    bool getRightNumber(int numbeR1, int numbeR2)
    {
        if (numbeR1 <= 0 & numbeR2 <= 0)
            return true;
        else
        {
            return false;
        }
    }