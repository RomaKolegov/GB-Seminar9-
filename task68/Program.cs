/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
int getUserNumber(string message)
{
    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(message);
    Console.ResetColor();
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
int m = getUserNumber("Введите число m");
int n = getUserNumber("Введите число n");

int AkkermanFunc(int m, int n)
{
	if (m == 0)
	{
		return n + 1;
	}
	else 
    {
        if (m > 0 && n == 0)
        {
            return AkkermanFunc(m - 1, 1);
        }
        else 
        {
           return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
        }
    }
}
Console.WriteLine($"результат функции равен {AkkermanFunc(m, n)}");