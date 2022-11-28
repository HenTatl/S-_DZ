//  Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
//  по убыванию элементы каждой строки двумерного массива.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  В итоге получается вот такой массив:
//  7 4 2 1
//  9 5 3 2
//  8 4 4 2

void SortMaxToMin()
{      
    
    Console.Write("Введите количество строк: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Введите количество стобцов: ");
    int columns = int.Parse(Console.ReadLine()!);
    Console.WriteLine($"Первоначальный массив {rows}x{columns}");
    int[,]numbers = new int[rows,columns];
    FillArray(numbers);
    PrintArray(numbers);
    Console.WriteLine("Отсортированный вариант:");  
    SortElements(numbers);
    PrintArray(numbers);

}
SortMaxToMin();
   
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

void SortElements(int[,] numbers)
{
  for (int i = 0; i < numbers.GetLength(0); i++)
  {
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
      for (int k = 0; k < numbers.GetLength(1) - 1; k++)
      {
        if (numbers[i, k] < numbers[i, k + 1])
        {
          int temp = numbers[i, k + 1];
          numbers[i, k + 1] = numbers[i, k];
          numbers[i, k] = temp;
        }
      }
    }
  }
}