// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// =======================

void Urav(double numk1, double numb1, double numk2, double numb2)
{
    if (numk1 == numk2 && numb1 == numb2)
    {
        Console.WriteLine("Прямые совпадают.");
    }
    else if (numk1 == numk2 && numb1 != numb2)
    {
        Console.WriteLine("Прямые паралельны и не имеют точки пересечения.");
    }
    else
    {
        double numx = (numb2 - numb1) / (numk1 - numk2);
        double numy = numk1 * numx + numb1;
        Console.WriteLine($"Прямые ппересекаются в точке ({numx};{numy})");
    }
}
// =======================
Console.WriteLine("Найдём точку пересечения двух прямых");
Console.WriteLine("Привет");

Console.WriteLine("  y1 = k1*x + b1 и y2 = k2*x + b2 ");
Console.WriteLine("====================================");


Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"  y1 = {k1}*x + {b1} и y2 = {k2}*x + {b2}");

Urav(k1, b1, k2, b2);
