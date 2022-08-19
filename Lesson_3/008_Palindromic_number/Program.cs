// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Clear();

Console.Write("Введите число состоящие из 5 символов: ");

string? number = Console.ReadLine();

string IsPalinrom(string num)
{
    if (num.Length != 5)
    {
        return "Указанное число имеет больше или меньше 5 символов";
    }

    if (num[0] == num[4] && num[1] == num[3])
    {
        return $"Число {num} является палиндромом!";
    }
    else return $"Число {num} не является палиндромом!";
}

string result = IsPalinrom(number);
Console.Write(result);