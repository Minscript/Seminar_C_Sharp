Console.Clear();
//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите кол-во чисел: ");
int mNumbers = Convert.ToInt32(Console.ReadLine());
int[] customArray = FillArray(mNumbers);
int countGreaterZero = FindGreaterZeroInArray(customArray);

// Заполняем массив
int[] FillArray(int countM)
{
    int[] array = new int[countM];
    for (int i = 0; i < countM; i++)
    {
        Console.Write($"Введите {i + 1} число: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine();
    return array;
}
/*
Пояснение: я решил не создавать заранее массив вне метода, чтобы потратить меньше памяти (за место 2х переменных с пустым и заполненным массивом).
*/


// Выводим массив на экран
void PrintArray(int[] arr, int countM)
{
    Console.Write($"Пользователь ввёл {countM} чисел: ");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

// Считаем, сколько чисел больше 0
int FindGreaterZeroInArray(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) { count++; }
    }
    return count;
}

PrintArray(arr: customArray, countM: mNumbers);
Console.Write($"Чисел больше нуля: {countGreaterZero}");