﻿// Подсчитать сумму цифр в числе

Console.Clear();

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int sum = 0;
while (n > 0 || n < 0)
{
    sum = sum + n  % 10;
    n = n / 10;
    
}
    Console.WriteLine(sum);
