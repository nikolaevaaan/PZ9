// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

namespace task66
{
    class Program
    {
        static void Main(string[] args)
    {
        int M = 1;
        int N = 15;
        int sum = Sum(M, N);
        Console.WriteLine($"M = {M}; N = {N} -> {sum}");      
    }

    static int Sum(int M, int N)
    {
        if (M > N)
        {
            return 0;
        }
        return M + Sum(M + 1, N);
    }
    }
}
