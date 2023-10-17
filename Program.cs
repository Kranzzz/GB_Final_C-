
// Задача 64:
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// -------------------------------------------------------------



// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         Console.Write("N = " + n + " -> ");
//         PrintNumbers(n);
//     }

//     static void PrintNumbers(int n)
//     {
//         if (n >= 1)
//         {
//             Console.Write(n);
//             if (n > 1)
//             {
//                 Console.Write(", ");
//             }
//             PrintNumbers(n - 1);
//         }
//     }
// }








// -------------------------------------------------

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// --------------------------------------------------


// using System;

// class Program
// {
//     static void Main()
//     {
//         Console.Write("Введите значение M: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение N: ");
//         int n = int.Parse(Console.ReadLine());

//         int sum = 0;
//         for (int i = m; i <= n; i++)
//         {
//             sum += i;
//         }

//         Console.WriteLine($"M = {m}; N = {n} -> {sum}");
//     }
// }





// --------------------------------------------------------------------
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
// ----------------------------------------------------------------------



// using System;

// class Program
// {
//     static int Ackermann(int m, int n)
//     {
//         if (m == 0)
//         {
//             return n + 1;
//         }
//         else if (n == 0)
//         {
//             return Ackermann(m - 1, 1);
//         }
//         else
//         {
//             return Ackermann(m - 1, Ackermann(m, n - 1));
//         }
//     }

//     static void Main(string[] args)
//     {
//         Console.Write("Введите значение m: ");
//         int m = int.Parse(Console.ReadLine());

//         Console.Write("Введите значение n: ");
//         int n = int.Parse(Console.ReadLine());

//         if (m < 0 || n < 0)
//         {
//             Console.WriteLine("Ввод отрицательных значений недопустим.");
//         }
//         else
//         {
//             int result = Ackermann(m, n);
//             Console.WriteLine($"A({m}, {n}) = {result}");
//         }
//     }
// }


// ----------------------------------------------------------------------------------


// --END--