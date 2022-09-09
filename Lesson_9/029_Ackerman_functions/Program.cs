//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
Console.Clear();

//Вводные данные
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

//Метод
int Akkerman(int M, int N) // Функция Аккермана A(m,n)
{
    if (M == 0) { return N + 1; };
    if (M != 0 && N == 0) { return Akkerman(M - 1, 1); }
    if (M > 0 && N > 0) { return Akkerman(M - 1, Akkerman(M, N - 1)); }
    return Akkerman(M, N);
}

void PrintColorText(string text, string color, bool line) // Выбор цвета для теста
{
    if (color == "green")
    {
        Console.ForegroundColor = ConsoleColor.Green;
    }
    else if (color == "red")
    {
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else if (color == "yellow")
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
    }

    if (line == true)
    {
        Console.WriteLine(text);
    }
    else
    {
        Console.Write(text);
    }
    Console.ForegroundColor = ConsoleColor.White;
}

//Вывод
if (M < 0 && N < 0) { return; }

PrintColorText($"Функция Аккермана A(m,n) = ", "yellow", false);
PrintColorText($"{Akkerman(M, N)}", "green", true);