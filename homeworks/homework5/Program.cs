// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2



// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
    
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void EvenInteger (int [] array)
// { 
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i] % 2 == 0)
//             count++;
//         }
    
// Console.WriteLine($"Всего чисел {array.Length},чётных из них: {count}");
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateRandomArray(size, minValue, maxValue);
// ShowArray(array);
// EvenInteger(array);





// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0



// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
    
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void UnevenInteger(int[] array)
// {
//     int uneven = 0;
//     for (int i = 0; i < array.Length; i++)
//     if (i % 2 != 1)
//     {
//         uneven = uneven + array[i];
//     }


// Console.WriteLine($"Сумма чисел на нечетных позициях: {uneven}");
// }


// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateRandomArray(size, minValue, maxValue);
// ShowArray(array);
// UnevenInteger(array);





// Задача 38: Задайте массив вещественных чисел.
//  Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
    
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void FindDifference(int[] array, int minValue, int maxValue)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < minValue)
//         {
//             minValue = array[i];
//         }
//         if (array[i] > maxValue)
//         {
//             maxValue = array[i];
//         }
//     }
//     Console.WriteLine($"Разница между {maxValue} и {minValue}: {maxValue-minValue}");
// }

// void ShowArray (int[] array)
// {
//     for(int i = 0;i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }


// Console.WriteLine("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input max value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());
// int [] array = CreateRandomArray(size, minValue, maxValue);
// ShowArray(array);
// FindDifference(array, maxValue, minValue);
