﻿// Задача 19 
// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
 
 if (num > 9999 & num <  100000)
 {
   
    if ((num/10000 == num%10) && ((num/1000)%10 == (num%100)/10))
    {
    Console.WriteLine("Число " + num + " является палиндромом");
    }
    else
    {
    Console.WriteLine("Число " + num + " не является палиндромом");
    }

}
else
{
    Console.WriteLine("Некорректный ввод!");
}
