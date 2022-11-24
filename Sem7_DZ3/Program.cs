// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Zadacha052()
{
    Console.WriteLine("Введите количество строк:");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов:");
    int m = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[n, m];
    FillArray(numbers);
    Console.WriteLine();
    PrintArray(numbers);
    Console.WriteLine("Среднее арифметическое каждого столбца:");
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            average = (average + numbers[i, j]);
        }
        average = average / n;
        Console.Write(Math.Round(average, 1) + "; " + "\t");
    }
}

Zadacha052();

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