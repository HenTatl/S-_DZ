// Задача 10: 
// Напишите программу, 
// которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 

Console.Write(" Enter natural 3-digit number: ");
int number = int.Parse(Console.ReadLine());

int SecondDig(int num)
{
    int nov = num / 10 % 10;
    return nov;
}
int result = SecondDig(number);

if (number > 100 && number < 1000) // трёхзначное число ?
    Console.WriteLine($"{number} -> second digit -> {result}");
else
    Console.WriteLine("Incorrect number");