// Задача 13: 
// Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

Console.Write("Enter natural a number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = TherdNuber(number);
  
    if (number > 99) Console.WriteLine($"{number} -> {result}");

    else if (number >= 1 && number < 100) Console.WriteLine($"{number} -> There is no third digit");

    else if (number <= 0) Console.WriteLine($"{number} -> Enter a natural  number");

int TherdNuber(int num) // metod
{

    while (num >= 1000)
    {
        num = num / 10;
    }
    num = num % 10;

    return num;

}

