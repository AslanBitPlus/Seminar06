// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

// =======================
int[] InputArray(int size)
{
    int[] inpArray = new int[size];
    for (int i = 0; i < inpArray.Length; i ++)
    {
        Console.Write($"Введите {i + 1} - число: ");
        inpArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return inpArray;
}
// =======================
void PrintArray(int[] array, string sep = " ")
{
    for (int i = 0; i < array.Length; i ++)
    {
        if (i == 0) Console.Write($"[{array[i]}{sep} ");
        else if (i < array.Length - 1) Console.Write($"{array[i]}{sep} ");
        else Console.Write($"{array[i]}]");
    }
}
// =======================

int PosElemArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] > 0) result += 1;
    }
    return result;
}
// =======================

Console.Write("Сколько чисел вы хотите ввести: ");
int arrSize = Convert.ToInt32(Console.ReadLine());

int[] arr = InputArray(arrSize);
PrintArray(arr, ";");

int posElem = PosElemArray(arr);

Console.WriteLine();
Console.WriteLine($"Вы ввели {posElem} положительных чисел");