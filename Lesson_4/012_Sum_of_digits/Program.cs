Console.Clear();
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// Метод суммирования чисел
int SumNumber(int num)
{
    int count = Convert.ToString(num).Length;
    int digit = 0;
    int result = 0;

    for (int i = 0; i < count; i++)
    {
        digit = num - num % 10;
        result = result + (num - digit);
        num = num / 10;
    }

    return result;
}

int result = SumNumber(number);
Console.WriteLine($"Сумма цифр в числе {number}: {result}");