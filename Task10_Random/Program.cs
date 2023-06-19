/*
Задача 10: Напишите программу, которая принимает на вход СЛУЧАЙНОЕ трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Random rand = new Random();
int number = rand.Next(100,1000);
int result = (number / 10) % 10;
Console.WriteLine($"The second digit of {number} is {result}.");