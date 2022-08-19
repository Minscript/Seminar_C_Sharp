// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();

//Создаём переменные
Console.Write("Введите любое число или 0 для генерации числа: ");
int number = Convert.ToInt32(Console.ReadLine());
char result;

//Генерируем число при желании пользователя от 1 до 99999
if (number == 0)
{
    Random random = new Random();
    number = random.Next(1, 100000);
    Console.WriteLine($"Рандомное число: {number}");
}

//Проверяем, есть ли у числа третья цифра
if (number < 100)
{
    Console.Write($"У числа {number} третьей цифры нет!");
}
else
{
    //Выполняем метод
    result = FindThreeNumber(number);
    Console.Write($"Третья цифра у числа {number} - {result}!");
}

//Создаём метод
char FindThreeNumber(int num)
{
    char three = num.ToString()[2];
    return Convert.ToChar(three);
}

/*
Скажу честно. Я запутался с конвертацией и преобразовывал типы данных в методе на рандоме. Не знаю, правильно ли выглядит код, 
но со своей задачей он справляется отлично. Он покажет третье число (а точнее символ в переменной number) или выводит что третей цифры в числе нет.
*/