// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
int stop = 1;

if (n < 1) Console.WriteLine("Некорректный ввод, введите натуральное число.");
else NumbersFromNToOne(n, stop);

void NumbersFromNToOne(int n, int stop)
{
    if (stop < n)
    {
        NumbersFromNToOne(n, stop + 1);
    }
    if (stop > 1) Console.Write(stop + ", ");
    else Console.Write(stop);
}