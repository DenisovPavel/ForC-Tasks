// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] firstArray(int row, int column) 
{
    int[,] array = new int[row, column];

    for (int i = 0; i < array.GetLength(0); i++) {      
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,9);
        }
    }
    for (int i = 0; i < array.GetLength(0); i++){       
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}
int[,] secondArray(int row1, int column1) 
{
    int[,] array = new int[row1, column1];

    for (int i = 0; i < array.GetLength(0); i++){      
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0,9);
        }
    }
    for (int i = 0; i < array.GetLength(0); i++){       
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "  " );
        }
    Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

int[,] finalmultiplyarray(int [,] firstarray, int [,] secondarray)
{   
    int [,] resultarray = new int[firstarray.GetLength(0), secondarray.GetLength(1)];
    if (firstarray.GetLength(1) == secondarray.GetLength(0))
    {
        for (int i = 0; i < firstarray.GetLength(0); i++)
        {
            for (int j = 0; j < secondarray.GetLength(1); j++)
            {
                for (int k = 0; k < firstarray.GetLength(1); k++)
                {
                    resultarray[i, j] += firstarray[i, k] * secondarray[k, j];
                }    
            }
        }       
    }
    else System.Console.WriteLine("Неравнозначный тип матриц! Задайте равнозначные параметры!!");
    for (int i = 0; i < resultarray.GetLength(0); i++)
    {       
        for (int j = 0; j < resultarray.GetLength(1); j++)
        {
            Console.Write(resultarray[i, j] + "  " );
        }
    Console.WriteLine();
    }
    Console.WriteLine(); 
    return resultarray;
}

finalmultiplyarray(firstArray(6,6), secondArray(6,6));

//TODO (Специально сохранил, не смог понять почему в консоль выводит System,int 32 вместо вывода массива)
//(голову сломал но так и не вывел(((((
// Console.Clear();

// Console.WriteLine("Введите количество строк двумерного массива:");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите количество столбцов двумерного массива:");
// int columns = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Минимальное возможное значение в двумерном массиве:");
// int min = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Максимальное возможное значение в двумерном массиве:");
// int max = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine();

// int[,] array = ToRandomArray(rows, columns, min, max);
// int[,] array2 = ToRandomArray(rows, columns, min, max);

// PrintArray(array, array2);
// Console.WriteLine();

// int[,] afterMult = ToMultiplyArray(array, array2);
// Console.WriteLine(string.Join(",", afterMult));

// int[,] ToRandomArray(int massiverows, int massivecolumns, int minelement, int maxelement)
// {
//     int[,] array = new int[massiverows, massivecolumns];

//     for (int rows = 0; rows < array.GetLength(0); rows++)
//     {
//         for (int columns = 0; columns < array.GetLength(1); columns++)
//         {
//             array[rows, columns] = new Random().Next(minelement, maxelement);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] massiv1, int[,] massiv2)
// {
//     for (int row = 0; row < massiv1.GetLength(0); row++) // 1 строка
//     {
//         for (int col = 0; col < massiv1.GetLength(1); col++) // 1 столбец
//             Console.Write(massiv1[row, col] + "  ");  // провели 2 4 4  . 2 4 4 
//         Console.Write(" | " + " "); // разделитель

//         for (int col = 0; col < massiv2.GetLength(1); col++) // 2 столбец

//             Console.Write(massiv2[row, col] + "  ");  // вывели
//         Console.WriteLine(); // на след строку
//     }
// }

// int[,] ToMultiplyArray(int[,] inputArray1, int[,] inputArray2)
// {
//     int rowinputArray1 = inputArray1.GetLength(0);
//     int columninputArray1 = inputArray1.GetLength(1); // 1  массив

//     int rowinputArray2 = inputArray2.GetLength(0);
//     int columninputArray2 = inputArray2.GetLength(1);  // 2 массив

//     int[,] resultArray = new int[rowinputArray1, columninputArray2];

//     for (int i = 0; i < rowinputArray1; i++) // a1строка = а1элемен * а2
//     {
//         for (int j = 0; j < columninputArray2; j++)
//         {
//             resultArray[i, j] = 0;

//             for (int k = 0; k < columninputArray1; k++){

//                 resultArray[i, j] = inputArray1[i, k] * inputArray2[k, j];
//             }
//         }
//     }
//     return resultArray;
// }



