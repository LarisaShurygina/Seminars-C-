// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да




// Console.WriteLine("Input 5-digit number: ");
// string? number = (Console.ReadLine());

// void FindPalindrom(string? number)
// {
//     if (number?[0] == number?[4] && number?[1] == number?[3])
//     Console.WriteLine("Это палиндром");

//     else
//     Console.WriteLine("Это не палиндром");
// }
// FindPalindrom(number);





// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// double FindDistance (double xa, double ya, double xb, double yb, double za, double zb)

// {
// return Math.Round(Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2)));
// }

// Console.WriteLine("Input coordinate X for first point: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y for first point: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z for first point: ");
// double za = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Input coordinate X for second point: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Y for second point: ");
// double yb = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Input coordinate Z for second point: ");
// double zb = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine($"Distance between our points -> {FindDistance(xa,ya,xb,yb,za,zb)}");




// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void CubeLine (int num)
// {
//     int counter = 1;

//     while (counter <= num)
//     {
//     Console.WriteLine($"{counter} -> {counter * counter * counter} ");
//     counter++;
//     }
// }

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// CubeLine(number);
