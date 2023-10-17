
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