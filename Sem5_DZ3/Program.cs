// Задача 38: Задайте массив вещественных чисел. Найдите разницу между  
// максимальным и минимальным элементов массива.
//  [3 7 22 2 78] -> 76

Console.Write("Введите длинну массива : ");
int size = Convert.ToInt32(Console.ReadLine());

void MaxMinDif()
{
    double[] numbers = new double[size];
    FillArray(numbers);
    PrintArray(numbers); 
    DiffMinMax(numbers);
}

void FillArray(double[]numbers)
{
    Random random = new Random ();
    for (int i =0; i< numbers.Length; i++)
    {
        numbers[i] = Math.Round(random.Next(-100, 100) + random.NextDouble(), 2);
    }
}

void PrintArray(double[]numbers)
{
    Console.WriteLine("Вывод массива");
    for (int i =0; i<numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

void DiffMinMax(double[]numbers)
{ 
    double diff=0;
    double min = numbers.Min();
    double max = numbers.Max();
    for (int i =0; i< numbers.Length; i++)
      {
         diff = numbers.Max() - numbers.Min();
        }
    
    Console.WriteLine($"максимальный элемент массива =>  {max}");
    Console.WriteLine($"минимальный элемент массива =>  {min}");
    Console.WriteLine($"разница =  {diff}.");        
}
MaxMinDif();
