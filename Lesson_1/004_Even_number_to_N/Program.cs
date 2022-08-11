// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();

//Ввод данных пользователем
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

//Проверка данных с выводом ответа
if (N<2)
{
    Console.Write("Чётных чисел нет или введено число < 0");
} else 
{
    Console.Write($"Чётные числа до {N}: ");
    for (int num=2; num<=N; num=num+2)
    {
        Console.Write($"{num}, ");
    }
}