// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int num2 = Convert.ToInt32(Console.ReadLine());
SumNum(num1, num2);
if (num1 >= num2)
{
Console.WriteLine("Некорректное значение, число M должно быть меньше, или равно числу N");
}

    Console.WriteLine($" сумма натуральных элементов  = {SumNum(num1, num2)}");

int SumNum(int num1, int num2)
{
    int result = 0;
    for (int i = num1; i <= num2; i++)
            {
                result += i;
            }
            return result;      
}

