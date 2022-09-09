//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
Console.Clear();

//Вводные данные
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

//Метод
void NumberToN(int N, int M)
{
    if (M > N)
    {
        return;
    }
    Console.Write($"{M} | ");
    NumberToN(N, M + 1);
}

//Выполнения кода
if (M > N) { return; }

Console.Write("| ");
NumberToN(N, M);