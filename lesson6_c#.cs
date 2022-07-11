/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

void showArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int[] fillingArray(int size) //наполнение массива числами пользователя
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число для индекса " + i + ": ");
        int num = Convert.ToInt32(Console.ReadLine());
        array[i] = num;
    }
    return array;
}

int findPositive(int[] array) //поиск положительных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Write("Введите длину числового массива: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] myArray = fillingArray(num);
showArray(myArray);
int sum = findPositive(myArray);
Console.Write("Количество положительных чисел в массиве: " + sum);





/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

https://ru.onlinemschool.com/math/assistance/cartesian_coordinate/lines_intersection/

y = k1 * x + b1
y = 5 * x + 2;
y(0) = 5*0+2 = 2; y(1) = 5*1+2 = 7;
a(0,2; 1,7)

y = k2 * x + b2
y = 9 * x + 4;
y(0) = 9*0+4 = 4; y(1) = 9*1+4 = 13;
b(0,4; 1,13)

точка пересечения:
x = (b1-b2) / ((k1-k2)* -1)
y = k2 * x + b2
*/

void linesCrossing(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / ((k1 - k2) * -1);
    double y = k2 * x + b2;

    if (double.IsNaN(x))
    {
        Console.WriteLine("Линии совпадают дуг с другом!");
        return;
    }

    if (double.IsInfinity(x) || double.IsInfinity(y))
    {
        Console.WriteLine("Линии параллельны!");
        return;
    }
    Console.WriteLine();
    Console.WriteLine("Точка пересечения прямых будет в координатах: X = " + x + "; Y = " + y);
}

Console.Write("Введите 'k1' для уравнения первой прямой (y = k1 * x + b1): ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 'b1' для уравнения первой прямой (y = k1 * x + b1): ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 'k2' для уравнения второй прямой (y = k2 * x + b2): ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 'b2' для уравнения второй прямой (y = k2 * x + b2): ");
int d = Convert.ToInt32(Console.ReadLine());
linesCrossing(a, b, c, d);
