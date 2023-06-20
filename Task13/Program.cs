/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

Анализ кода из идеального решения. Сама не смогла решить.
*/

int Prompt(string message) // Ввод числа, преобразование строки в число. Prompt - получение текстовых данных от пользователя.
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdDig(int number) // Для определения третьей цифрыв числе.
{
    while (number > 999) // Нижняя граница указана, верхняя граница не указана. Очевидно!
    {
        number /= 10; 
    }
    return number % 10; // Возвращается остаток от деления на 10, т. е. цифра после запятой, т. е. третья цифра?
}

bool ValidateNumber(int number) // Проверка, двухзначное число или больше.
{
    if(number < 100)
    {
        Console.WriteLine($"There is no third digit in {number}.");
        return false;
    }
    return true;
}

int number = Prompt("Input number --> "); // Ввод числа с помощью метода.
if(ValidateNumber(number)) // Проверка условия.
{
    Console.WriteLine(GetThirdDig(number)); // Вывод результата.
}