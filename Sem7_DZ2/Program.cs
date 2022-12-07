//  Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
//  и возвращает позицию этого элемента или же указание, что такого элемента нет.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  17 -> такого числа в массиве нет.

Console.WriteLine();
Console.Write("Введите количество строк : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите искомое число : ");
int number = Convert.ToInt32(Console.ReadLine());
int[,] array = CreateRandomArray(rows, columns);
PrintArray(array);
FindElementPosition(array);

int[,] CreateRandomArray(int rows, int columns)   // Функция заполнения массива случайными числами
{
    int[,] array = new int [rows, columns];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = random.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)      // Функция вывода массива в консоль
{
    Console.WriteLine();
    Console.WriteLine("Сгенерированный массив  :");
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindElementPosition (int[,] array)       // Функция поиска индекса искомого числа
{
    if (number > 1 || number < 10)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] == number)
                {
                    Console.WriteLine($"Позиция искомого числа: строка {i + 1} столбец {j + 1}");
                }
            }
        }
    }
    if(number < 0 || number >= 10)
    {
        Console.WriteLine("Такого числа нет в таблице ");
    }
}
