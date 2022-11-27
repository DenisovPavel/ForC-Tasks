// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.Write("Введите любое число : ");
int a = Convert.ToInt32(Console.ReadLine());
int index = 0;

if (index <= a)
            {
                Console.WriteLine(a % 100);
                a /= 10;                
            }

else{
Console.Write(" Найти третью цифру от числа невозможно! : ");
}



