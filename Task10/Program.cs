/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.WriteLine("Input a 3-digit number --> ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000)
{
    int result = (num / 10) % 10;
    Console.WriteLine($"The second digit of {num} is {result}.");
}
else
{
    Console.WriteLine($"Error, {num} is not a 3-digit number.");
}

/* Including negative numbers?

Console.WriteLine("Input a 3-digit number --> ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000 || num < -99 && num > -1000)
{
    int result = (num / 10) % 10;
    Console.WriteLine($"The second digit of {num} is {result}.");
}
else
{
    Console.WriteLine($"Error, {num} is not a 3-digit number.");
}
*/