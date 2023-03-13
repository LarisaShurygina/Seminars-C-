// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int colums = Convert.ToInt32(Console.ReadLine());
// double[,] numbers = new double[rows, colums];


// void ArrayRandomNumbers(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
//         }
//     }
// }

// void PrintArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine(" ");
//     }
// }

// ArrayRandomNumbers(numbers);
// PrintArray(numbers);




// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



// Console.WriteLine("Input number of row: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colum: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int [,] numbers = new int [5,5];
// ArrayRandomNumbers(numbers);

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("Такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"Значение элемента {n} строки и {m} столбца = {numbers[n-1,m-1]}");
// }

// PrintArray(numbers);

// void ArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(-100, 100)/10;
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }   
//         Console.WriteLine(""); 
//     }
// }



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




// Console.WriteLine("Input number of rows: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of colums: ");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] numbers = new int[n, m];
// ArrayRandomNumbers(numbers);


// for (int j = 0; j < numbers.GetLength(1); j++)
// {
//     double average = 0;
//     for (int i = 0; i < numbers.GetLength(0); i++)
//     {
//         average = (average + numbers[i, j]);
//     }
//     average = average / n;
//     Console.Write(average + "; ");
// }
// Console.WriteLine();
// PrintArray(numbers);



// void ArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine("");
//     }
// }