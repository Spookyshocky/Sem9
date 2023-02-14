// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void GetSum(int m, int n, int sum)
{
    if (m > n)
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
        return;
    }
    sum = sum + (m++);
    GetSum(m, n, sum);
}


Console.WriteLine("Введите начальное число M:");
int numM = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите начальное число N:");
int numN = int.Parse(Console.ReadLine()!);
GetSum(numM, numN, 0);