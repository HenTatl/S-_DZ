// Задача 4: 
//Напишите программу, которая принимает на вход три числа и 
//выдаёт максимальное из этих чисел

Console.WriteLine("Enter the First number :");
int numberA = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a Second number :");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a Third number :");
int numberC = int.Parse(Console.ReadLine());

int max = numberA;
if (numberB > max)
{
    max = numberB;
}
if (numberC > max)
{
    max = numberC;
}

else
{
    Console.WriteLine($" Maximum value is {max}");
}