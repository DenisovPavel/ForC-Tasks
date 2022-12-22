// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
Console.Write("Введите b1 число:");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k1 число:");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите b2 число:");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите k2 число:");
double k2 = Convert.ToDouble(Console.ReadLine());

GetTwoPoints(b1, k1, b2, k2);

void GetTwoPoints(double B1, double K1, double B2, double K2)
{
    double x = 0;
    double y1 = k1 * x + b1;
    double y2 = k2 * x + b2;
    double k3 = k1 - k2;
    double b3 = b2 - b1;
    x = b3 / k3;
    y2 = k2 * x + b2;
    Console.Clear();
    Console.WriteLine($"Значения b1 - { b1 }, k1 - {k1}, b2 - {b2 }, k2 - {k2 }; ");
    Console.WriteLine($"Точка пересечения двух прямых ( {x} , {y2} ) ");
}

