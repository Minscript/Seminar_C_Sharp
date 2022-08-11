// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();

//Ввод данных пользователем
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

//Проверка данных с выводом ответа
if (firstNumber>secondNumber)
{
    Console.Write($"Число {firstNumber} больше числа {secondNumber} ({firstNumber}>{secondNumber})");
} else if (secondNumber>firstNumber)
{
    Console.Write($"Число {secondNumber} больше числа {firstNumber} ({secondNumber}>{firstNumber})");
} else {
    Console.Write($"Числа равны ({secondNumber}={firstNumber})");
}