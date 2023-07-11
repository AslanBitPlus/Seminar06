// Не используя рекурсию выведите первые N чисел Фибоначчи
// Первые два числа Фибоначчи: 0 и 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// =======================
void Fibonachi(int[] array, int n1, int n2)
{
    array[0] = n1;
    array[1] = n2;
    for (int i = 2; i < array.Length; i ++)
    {
        array[i] = array[i - 2] + array[i - 1];
    } 
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

Console.Write("Введите десятичное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 2)
{
    int[] arr = new int[number]; 

    Fibonachi(arr, 0, 1);

    PrintArray(arr, ",");
}
else Console.WriteLine("Ошибка ввода");