// Задача 2: 
// Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

Console.WriteLine("Enter the First number :");

int numberA = int.Parse(Console.ReadLine());


Console.WriteLine("Enter Second number :");
int numberB = int.Parse(Console.ReadLine());

if (numberA > numberB)
{

    Console.WriteLine(numberA + " is larger than " + numberB);

}

else

{
    if (numberA < numberB)
        Console.WriteLine(numberA + " is smaller than " + numberB);
    else
        Console.WriteLine(numberA + " is equal to " + numberB);
}

