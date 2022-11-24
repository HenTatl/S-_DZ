//
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Clear();

Console.Write("Количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());

int [,] array = FillArray(rows, columns, -10 , 10);

PrintArray(array);

int [,] FillArray(int rows, int columns, int min, int max){
    int[,] array = new int[rows,columns];
    for(int i = 0; i < rows; i++){
        for(int j = 0; j< columns; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray(int [,] filledArray){
    for(int i = 0; i<filledArray.GetLength(0);i++){
        for(int j = 0; j < filledArray.GetLength(1);j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}