// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter first number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int numb2 = Convert.ToInt32(Console.ReadLine());

if (numb1>numb2)
{
    Console.WriteLine($"{numb1} is bigger");
}
else if (numb2>numb1)
{
    Console.WriteLine($"{numb2} is bigger");
}
else Console.WriteLine("They're equal");