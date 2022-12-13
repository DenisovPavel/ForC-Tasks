// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите элементы(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine();
Console.WriteLine($"Количество чисел больше 0 ввёл пользователь равно: {string.Join(",", ShowNumbers(arr))}");

int ShowNumbers(int[] array)
{int count = 0;
    int[] massiv = new int[array.Length];

    for (int i = 0; i < massiv.Length; i++)
    {
        
        if (massiv[i] > 0)
        {
            count++;
        }
    }
    return count;
}










































// Console.WriteLine("Введите числа:");
// int number = Convert.ToInt32(Console.ReadLine()); // пользователь ввел число


// FillArray(number);
// Console.WriteLine($"Исходный массив [ {string.Join(" ", number)} ]");  // продемонстрировал метод число-> массив;

// GetNumberMoreZero(number); // метод показывающий количество чисел которые больше 0
// Console.WriteLine($"Колличество чисел больше 0 : {string.Join(" ", number)} ");

// int[] FillArray(int size)  // метод перевода числа в массив
// {
//     int[] numbersarray = new int[size];
//     for (int i = 0; i < numbersarray.Length; i++) ;
//     return numbersarray;
// }


// int count = 0;
// void GetNumberMoreZero(int num) // метод определяющий что N числа больше 0 (записывает в счетчик и выводит счетчик)
// {
//     int count = 0;
//     int[] morezero = new int[num];

//     for (int i = 0; i < morezero.Length; i++)

//         if (morezero[i] > 0) // сравнил элемент с 0
//         {
//             count++; ; // если он больше 0, то к счетчику прибавил 1
//         }
// }












// FillArray(str);
// Console.WriteLine($"Исходный массив: [ {int.Join(",", str)} ] ");
// GetNumberMoreZero(str);



// int[] FillArray(int[] size)
// {
//     int[] massiv = new int[size.Length];

//     for (int i = 0; i < size.Length; i++)
//     massiv[i]= size[i];
//     return massiv;
// }



// Console.WriteLine($"Колличество чисел введенного массива, которые больше 0 ровно:{GetNumberMoreZero(str)} ");


// int GetNumberMoreZero(int[] numbers)
// {

//    // int[] morezero = new int[numbers.Length];
//     int result = 0;
//     for (int i = 0; i < numbers.Length; i++){
// if (numbers[i] > 0)

//     }





// Console.WriteLine("Введите числа:");
// int size = Convert.ToInt32(Console.ReadLine());

// Fillstr(size);
// Console.WriteLine($"Исходный массив: [ {int.Join(",", size)} ] ");
// getNumberMoreZero(size);
// Console.WriteLine($"Колличество чисел введенного массива, которые больше 0 ровно:{getNumberMoreZero(size)} ");

// int[] Fillstr(int str)
// {
//     int[] massiv = new int[str];
//     for (int i = 0; i < str.Length; i++) ;
//     return massiv;
// }

// int getNumberMoreZero(int numbers)
// {

//     int[] morezero = new int[size];
//     int result = 0;
//     for (int i = 0; i < morezero.Length; i++)
//         if (morezero[i] > 0)
//             result++;
//     return result;
// }