//Задача 6: 
//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Enter number :");

int numberA = int.Parse(Console.ReadLine());

if (numberA % 2 == 0)

{
    Console.WriteLine(numberA + " is an even number");
}

else

{
    Console.WriteLine(numberA + " is an odd number");
}