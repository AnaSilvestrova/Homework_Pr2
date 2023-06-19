/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

Console.WriteLine("Input number --> ");
int num = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"The third digit of {num} is {result}.");


    Console.WriteLine($"Error, there is no third digit.");