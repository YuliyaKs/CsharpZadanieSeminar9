// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

using System;
using static System.Console;

Clear();
Write("Введите число M: ");
int m = int.Parse(ReadLine());
Write("Введите число N: ");
int n = int.Parse(ReadLine());

WriteLine(SumNumbers(m, n));

int SumNumbers(int start, int end)
{
    int sum = 0;
    if (start > end) 
        return sum;
    sum = start + SumNumbers(start + 1, end);
    return sum;
}
