﻿// Задача 8: 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

Console.Write ("Enter N=");
int N = int.Parse(Console.ReadLine());
int i = 1;
if( N > 0)
{

 while (i <= N)
 
    {

        if (i % 2 == 0)
        Console.Write ("{0} ", i);
        ++i;

    }
}    
    else
{
    Console.WriteLine(" Enter a positive number ");
}


