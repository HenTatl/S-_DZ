// Задача 15: 
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Write("Enter number of the day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());


if (number < 1 || number > 8) {
	Console.WriteLine("Это Некорректное число");
}
else if (number == 6 || number == 7) {
	Console.WriteLine("Это выходной день");
}
else if (number >= 1 && number < 7) {
	Console.WriteLine("Это рабочий день");
}