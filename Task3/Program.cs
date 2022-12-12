// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Enter first number: ");
int numb1 = Convert.ToInt32(Console.ReadLine());

if (numb1 % 2==0)
{
   Console.WriteLine("yes");         
}
else
{
    Console.WriteLine("no");
}