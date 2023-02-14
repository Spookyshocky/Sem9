// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.

void PrintNum(int num)
{
    if (num == 0) return;
    Console.Write($" {num}");
    PrintNum (num - 1);
}

PrintNum(8);