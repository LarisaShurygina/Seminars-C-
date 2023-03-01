// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


int FindDegree(int A, int B)
{
    int degree = 0;
    
    Math.Pow(A, B);
Console.WriteLine("A^B = " + Math.Pow(A, B));
    return degree;
}

Console.WriteLine("Input A");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input B");
int B = Convert.ToInt32(Console.ReadLine());

FindDegree(A, B);



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

