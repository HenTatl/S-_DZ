// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите число элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());

void SumOddPositions()
{
        int[]numbers = new int[size];
    
    FillArray(numbers);
    PrintArray(numbers); 
    SumUnevenIndex(numbers);
}
SumOddPositions();

void FillArray(int[]numbers)
{
    Random random = new Random ();
    for (int i =0; i< numbers.Length; i++)
    {
        numbers[i] = random.Next(-100, 101);
    }
}

void PrintArray(int[]numbers)
{
    Console.WriteLine("Вывод массива :");
    for (int i =0; i<numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

void SumUnevenIndex(int[]numbers)
{ 
    int sum =0;
    for (int i =0; i< numbers.Length; i++)
      {
            if (i % 2 == 1)
        {
            sum = sum + numbers[i];
        }
        }
    Console.WriteLine($"сумма нечетных элементов =  {sum} .");   
       
}