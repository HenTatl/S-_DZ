// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


Console.WriteLine("Введите число");
int numberA = int.Parse(Console.ReadLine()!);
void SumDigitsNumber()
{
    int result = 0;
  
    if (numberA > 0)
    {
        while (numberA != 0)
        {
            result = numberA % 10 + result;
            numberA = numberA / 10;
        }
        Console.WriteLine("Сумма цифр в числе = " + result);
    }
     else
    {
        while (numberA != 0)
        {
            result = numberA % 10 + result;
            numberA = numberA / 10;
        }
        Console.WriteLine("Сумма цифр в числе = " + (-1 * result));
    }
}

SumDigitsNumber();