//
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите количество строк : ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов : ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows,columns];
FillArray(numbers);
Console.WriteLine("Сгенерированный массив :");
void PrintArray()
{
    for (int i =0; i< rows; i++)
    {
        for (int j =0; j< columns; j++)
        {
            Console.Write(numbers[i,j] + " \t");
        }
        Console.WriteLine();
    }
}

PrintArray();

void FillArray(double[,] numbers)
{
    Random random = new Random ();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i< rows; i++)
    {
        for (int j = 0; j< columns; j++)
        {
         numbers[i,j] = Convert.ToDouble(random.Next(-100, 101)/10.0); 
        }
    }
}