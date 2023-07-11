﻿// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное
// 46 -> 101110
// 13 -> 1101
// 2 -> 10

// =======================
int[] DecToBinArr(int num)
{
    int digCount = 0;
    int num1 = num;
    while (num1 != 0)
    {
        num1 = num1 / 2;
        digCount += 1;
    }

    int[] digitArray = new int[digCount];
 while (num != 0)
    {
        digitArray[digCount - 1] = num % 2;
        num = num / 2;
        digCount -= 1;
    }    


    return digitArray;
}

// =======================
string DecToBinStr(int num)
{
    string result = string.Empty;
    while (num != 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result; 
}

// =======================
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
        Console.Write($"{array[i]}");
}
// =======================

Console.Write("Введите десятичное число: ");
int decNumber = Convert.ToInt32(Console.ReadLine());

int[] arr = DecToBinArr(decNumber);

PrintArray(arr);

Console.WriteLine();
Console.Write(DecToBinStr(decNumber));