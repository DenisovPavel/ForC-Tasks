// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.Write("Введите A(X) число:");
double numberAX = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите A(Y) число:");
double numberAY = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите A(Z) число:");
double numberAZ = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите B(X) число:");
double numberBX = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите B(Y) число:");
double numberBY = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите B(Z) число:");
double numberBZ = Convert.ToDouble(Console.ReadLine());

double distanceAB = Math.Sqrt(Math.Pow(numberBX - numberAX, 2) + Math.Pow(numberBY - numberAY, 2) + Math.Pow(numberBZ - numberAZ, 2));
Console.Write(Math.Round(distanceAB, 2, MidpointRounding.ToZero));

