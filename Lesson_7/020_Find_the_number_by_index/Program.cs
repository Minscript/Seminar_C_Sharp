Console.Clear();
// Напишите программу, которая на вход принимает число и ищет в двумерном массиве, и возвращает индексы этого элемента или же указание, что такого элемента нет.

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();


int[,] CreateFilledArray(int str, int col, int min, int max) //Создаёт массив и заполняет его числами
{
    int[,] arr = new int[str, col];
    Random random = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(min, max + 1);
        }
    }
    return arr;
}

void FindNumberInArray(int[,] arr, int num) //Находит в массиве указанное число
{
    bool thereIs = false; //Если не найдёт число, останется на false

    Console.Write($"Число {num} в массиве: ");

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (num == arr[i, j]) //Выводит индекс числа
            {
                Console.Write($"[{i}, {j}] ");
                thereIs = true;
            }
        }
    }
    if (thereIs == false)
    {
        Console.Write("отсутствует!");
    }
    Console.WriteLine();
}

void PrintArray(int[,] arr, int num) //Показывает массив
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == num)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{arr[i, j]} ");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{arr[i, j]} ");
            }
        }
        Console.WriteLine();
    }
}

int[,] array = CreateFilledArray(str: 5, col: 5, min: 0, max: 9);
FindNumberInArray(array, number);
PrintArray(array, number);
Console.ForegroundColor = ConsoleColor.White;
