//  Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  5 2 6 7
//  Программа считает сумму элементов в каждой строке и выдаёт 
//  номер строки с наименьшей суммой элементов

Console.Write("Введите число строк таблицы: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов таблицы: ");
int columns = int.Parse(Console.ReadLine()!);

void MinSumRows()
{
    Console.WriteLine($"Массив размера {rows}x{columns}");
    int[,]numbers = new int[rows,columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine($"Наименьшая сумма элементов в {MinSumOfElements(numbers)} строке.");
   }
MinSumRows();
   
void FillArray(int[,] numbers)
{
    Random random = new Random ();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
     for (int i = 0; i< rows; i++)
    {
        for (int j = 0; j< columns; j++)
        {
         numbers[i,j] = random.Next(-10, 11);
        }
        }
}

void PrintArray(int[,] numbers)
 {
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i =0; i< rows; i++)
    {
        for (int j =0; j< columns; j++)
        {
            Console.Write(numbers[i,j] + " \t");
        }
        Console.WriteLine();
    }
 }

       int MinSumOfElements(int[,] numbers)
{
    int min = 0;
    int sum = int.MaxValue;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int rowSumm = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            rowSumm += numbers[i, j];
        }
        if (rowSumm < sum)
        {
            sum = rowSumm;
            min = i+1;
        }
    }
    return min;
}