// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void MatrixProduct()
{
Console.Write("Ведите кол-во строк первой матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите кол-во колонок первой матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Ведите кол-во строк второй матрицы: ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите кол-во колонок второй матрицы: ");
int d = Convert.ToInt32(Console.ReadLine());

if (b != c)
    Console.Write("Невозможно найти произведение двух матриц.");
else
{
    int[,] matrix1 = new int[a, b];
    int[,] matrix2 = new int[c, d];
    FillArray(matrix1);
    FillArray(matrix2);
    Console.WriteLine($"Первая матрица:");
    PrintArray(matrix1);
    Console.WriteLine();
    Console.WriteLine($"Вторая матрица:");
    PrintArray(matrix2);
    Console.WriteLine();
    int[,] result = new int[b,c];
    Console.WriteLine($"Результирующая матрица :");
    PrintArray(MultiplyArrays(matrix1, matrix2));
    
}

}
MatrixProduct();

void FillArray(int[,] matrix)
{
    Random random = new Random ();
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
     for (int i = 0; i< rows; i++)
    {
        for (int j = 0; j< columns; j++)
        {
         matrix[i,j] = random.Next(-10, 11);
        }
        }
}

void PrintArray(int[,] matrix)
 {
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i =0; i< rows; i++)
    {
        for (int j =0; j< columns; j++)
        {
            Console.Write(matrix[i,j] + " \t");
        }
        Console.WriteLine();
    }
 }

int[,] MultiplyArrays(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix2.GetLength(1), matrix1.GetLength(0)];

    for (int i = 0; i < matrix2.GetLength(1); i++)
    {
        for (int j = 0; j < matrix1.GetLength(0); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum = sum + matrix1[i, k] * matrix2[k, j];
                result[i, j] = sum;
            }
        }
    }
    return result;
}