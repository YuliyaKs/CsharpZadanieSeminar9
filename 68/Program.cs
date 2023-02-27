// Задача 68. Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;
using static System.Console;

Clear();
Write("Введите число N: ");
double n = double.Parse(ReadLine());
Write("Введите число M: ");
double m = double.Parse(ReadLine());

WriteLine(Ackermann(n, m));

double Ackermann(double n, double m)
{
    double result = 0;
    if (n == 0)
        result = m + 1;
    else if (n != 0 && m == 0)
        result = Ackermann(n - 1, 1);
    else
        result = Ackermann(n - 1, Ackermann(n, m - 1));
    return result;
}
