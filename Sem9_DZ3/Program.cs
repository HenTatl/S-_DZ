// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int FunctionAckerman (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return FunctionAckerman(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return FunctionAckerman(numberM - 1, FunctionAckerman(numberM, numberN - 1));
return FunctionAckerman(numberM, numberN);
}
Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {FunctionAckerman(numberM, numberN)}");
