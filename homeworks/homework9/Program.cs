// Задача 64: Задайте значение N. Напишите программу, которая выведет
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


// int n = InputInteger("Input positive integer:");
// int m = 1;
// if (n < 1)
// {
//     Console.WriteLine("Not positive integer");
// }
// Console.WriteLine(PosInteger(n, m));

// int PosInteger(int n, int m)
// {
//     if (n == m)
//         return n;
//     else
//         Console.Write($"{PosInteger(n, m + 1)}, ");
//     return m;
// }

// int InputInteger(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }




// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



// int m = InputInteger("Input m: ");
// int n = InputInteger("Input n: ");
// Console.WriteLine($"Сумма элементов от {m} до {n} = {CountSum(m, n)}");

// int InputInteger(string output)
// {
//     Console.Write(output);
//     return int.Parse(Console.ReadLine());
// }

// int CountSum(int m, int n)
// {
//     if (m == n)
//         return n;
//     return n + CountSum(m, n - 1);
// }