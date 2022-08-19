// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();

//Ввод данных пользователем
Console.Write("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int lastNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

//Проверка данных с выводом ответа
if (max == secondNumber && max == lastNumber)
{
    Console.Write("Введёные числа равны!");
}
else
{
    if (max < secondNumber) { max = secondNumber; }
    if (max < lastNumber) { max = lastNumber; }
    Console.Write($"{max} является максимальным числом из чисел: {firstNumber}, {secondNumber}, {lastNumber}");
}