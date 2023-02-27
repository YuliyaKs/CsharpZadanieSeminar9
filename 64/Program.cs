// Задача 64. Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

using System;
using static System.Console;

Clear();
Write("Введите значение N: ");
int n = int.Parse(ReadLine());

WriteLine(PrintNumbersNto1(n));

string PrintNumbersNto1(int number)
{
    if (number == 1)
    {
        return number.ToString();
    }
    string s = number.ToString() + " " + PrintNumbersNto1(number - 1);
    return (s);
}
