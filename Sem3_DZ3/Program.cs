// Задача 23
//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.


Console.Clear(); 
Console.WriteLine(); 

Console.Write("Введите число:   "); 
string writeN = Console.ReadLine()!;

int N = Convert.ToInt32(writeN); 

int[] GetCubeTable(int N) 
{
    int[] CubeArray = new int[N]; 
    for (int i = 0; i < N; i++) 
    {
         CubeArray[i] = (i + 1) * (i + 1) * (i + 1);
    }

    return CubeArray;
}

void PrintTable(int[] Array) 
{

    int number = 1; 
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine($"{number} ^ 3 = {Array[i]}");
        number++;
    }
}

int[] CubeTable = GetCubeTable(N);
PrintTable(CubeTable);
