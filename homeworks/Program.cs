
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3



// Console.WriteLine("First number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int max = 0;
// int min = 0;
// if (num1 > num2)
// {
//     max = num1;
//     min = num2;
//     Console.WriteLine($"Max number: {num1}");
//     Console.WriteLine($"Min number: {num2}");
// }
// else 
// {
//     max = num2;
//     min = num1;
//     Console.WriteLine($"Max number: {num2}");
//     Console.WriteLine($"Min number: {num1}");
// }





// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// Console.WriteLine("First number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Third number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = 0;

// if (num1 > num2 & num1 > num3)
// {
//     max = num1;
//     Console.WriteLine($"Max number: {num1}");
// }

// if (num1 > num2 & num1 < num3)
// {
//     max = num3;
//     Console.WriteLine($"Max number: {num3}");
// }

// if (num1 < num2 & num2 > num3)
// {
//     max = num2;
//     Console.WriteLine($"Max number: {num2}");
// }

// if (num1 < num2 & num2 < num3)
// {
//     max = num3;
//     Console.WriteLine($"Max number: {num3}");
// }




// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет


// Console.WriteLine("Number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num % 2 == 0)
// {
//     Console.WriteLine("Чётное число");
// }
// else
// {
//     Console.WriteLine("Нечётное число");
// }





// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8


// Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int current = 2;

// while (current <= num)
// {
//     Console.Write(current + " ");
//     current = current + 2;
// }