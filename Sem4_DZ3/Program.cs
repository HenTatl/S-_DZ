// Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел 
// с клавиатуры и далее выводит массив на экран в одну строку.

Console.Write("Введите количество элементов массива: ");
int arrayCount = int.Parse(Console.ReadLine());

int[] Array = new int[arrayCount];

for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    Array[i] = int.Parse(Console.ReadLine());
}
Console.Write("Вывод массива: ");

for (int i = 0; i < Array.Length - (Array.Length - 1); i++)
{
    Console.Write($"[{String.Join(",", Array)}]");
}