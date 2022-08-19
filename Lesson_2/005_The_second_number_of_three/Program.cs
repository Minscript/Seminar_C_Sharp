// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();

//Создаём переменные
Console.Write("Введите трехзначное число или 0 для генерации числа: ");
int number = Convert.ToInt32(Console.ReadLine());
int result;

//Проверяем ввод переменной и выполняем метод
if (number == 0)
{
    //Генерируем число за место пользователя, не забываем показать его.
    Random random = new Random();
    number = random.Next(100, 1000);
    Console.WriteLine($"Рандомное число: {number}");

    result = FindCentralNumber(number);
    Console.Write($"Вторая цифра числа {number} - {result}");
}
else if (number < 100 || number >= 1000)
{
    //Завершаем программу если пользователь ошибся
    Console.Write("Вы ввели не трёхзначное число!");
}
else
{
    result = FindCentralNumber(number);
    Console.Write($"Вторая цифра числа {number} - {result}");
}


//Создаём метод по нахождению второго числа
int FindCentralNumber(int num)
{
    num = num / 10 % 10;
    return num;
}