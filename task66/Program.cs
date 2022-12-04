/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
int getUserNumber(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
int numberM = getUserNumber("Введите число M");
int numberN = getUserNumber("Введите число N");
int sumOfNumbers = printRange(numberM, numberN);
Console.WriteLine($"Сумма натуральных чисел от {numberM} до {numberN} равна {sumOfNumbers}");

int printRange(int numberM, int numberN)
{
    if (numberN < numberM)
    {
        return 0;
    }
    return numberN + printRange(numberM, numberN - 1);
}