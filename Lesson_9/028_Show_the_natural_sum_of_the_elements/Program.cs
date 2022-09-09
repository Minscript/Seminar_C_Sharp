//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();

//Вводные данные
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

//Метод
int SummaMToN(int M, int N) // Сложить промежуток между M и N
{
    if (M == N)
    {
        return N;
    }
    return N + SummaMToN(M, N - 1);
}

void NumberToN(int N, int M) // Показать от M до N
{
    if (M > N)
    {
        return;
    }
    if (M < N)
    {
        Console.Write($"{M} + ");
    }
    else
    {
        Console.Write($"{M} = ");
    }
    NumberToN(N, M + 1);
}

void PrintColorText(string text, string color) // Выбор цвета для теста
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
    Console.WriteLine(text);
    Console.ForegroundColor = ConsoleColor.White;
}

//Выполнения кода
if (M > N) { return; }

Console.WriteLine();

NumberToN(N, M);
PrintColorText(text: $"{SummaMToN(M, N)}", color: "green");