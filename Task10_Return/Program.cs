/*
Задача 10: Напишите программу, которая принимает на вход СЛУЧАЙНОЕ трёхзначное число и на выходе показывает вторую цифру этого числа.
*/

int GetSecDigit(int number)
{
    Console.Write(number + " => ");
    
    int number1 = number / 10;
    int result = number1 % 10;
    
    return result;
}

int numRand = new Random().Next(100, 1000);
int secDigit = GetSecDigit(numRand);
Console.WriteLine($"The second digit of {numRand} is {secDigit}.");
