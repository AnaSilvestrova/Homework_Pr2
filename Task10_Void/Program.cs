/*
Задача 10: Напишите программу, которая принимает на вход СЛУЧАЙНОЕ трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

void GetSecNumber()
{
    int number = new Random().Next(100, 1000);

    Console.Write(number + " => ");
    
    int result = (number / 10) % 10;
    
    Console.WriteLine($"The second digit of {number} is {result}.");
}

GetSecNumber();