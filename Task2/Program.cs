﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter first number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int numb2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int numb3 = Convert.ToInt32(Console.ReadLine());

int max = numb1;
if (numb2>max)
{
    max = numb2;
}
if (numb3>max)
{
    max = numb3;
}
Console.WriteLine($"The max number is {max}");