﻿// Задача 40: Напишите программу, которая ппринимает на вход три
// числа и проверяет, может ли существовать т реугольник со
// сторонами таой длины


// =======================
bool IsExistsTriangle(int a, int b, int c)
{
    bool result = false;
    if (a < b + c && b < a + c && c < a + b) result = true;
    else result = false;
    return result;
}
// =======================

Console.Write("Введите длину стороны а: ");
int sizeA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину стороны b: ");
int sizeB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите длину стороны c: ");
int sizeC = Convert.ToInt32(Console.ReadLine());


bool existsTriangle = IsExistsTriangle(sizeA, sizeB, sizeC);

Console.WriteLine(existsTriangle);
