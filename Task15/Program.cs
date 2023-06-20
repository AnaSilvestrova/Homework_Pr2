/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

Анализ идеального решения, сама не смогла решить.
*/

int Prompt(string message) // Ввод числа, преобразование строки в число. Prompt - получение текстовых данных от пользователя.
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend (int weekDay) // Проверка, выходной или будни. Не нужен словарь!
{
    if (weekDay > 5)
    {
        return true;
    }
    return false;
}

bool ValidateNumber(int number) // Проверка, правильное ли введено число, не больше ли семи.
{
    if(number > 0 && number <= 7)
    {
        return true;
    }
    Console.WriteLine("It is not a day of the week.");
    return false;
}

int weekDay = Prompt("Input number --> "); // Вывод номера, проверка, вывод результата. 
if (ValidateNumber(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Yes, it's weekend.");
    }
    else
    {
        Console.WriteLine("No, it's a working day.");
    }
}