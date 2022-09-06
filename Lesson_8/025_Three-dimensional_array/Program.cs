// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Console.Clear();

// Вводные данные
Console.WriteLine($"Введите размер массива по X, Y и Z!");

Console.Write($"Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

int[,,] array = new int[x, y, z];

// Методы
void PrintArrayAndIndex(int[,,] arr) // Выводим массив в консоль
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{arr[i, j, k]} ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"({i},{j},{k})");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("; ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void FillArray(int[,,] arr) //Заполняем массив без повторений
{
    int[] temp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
    int number;
    Random random = new Random();
    for (int i = 0; i < temp.GetLength(0); i++)
    {

        temp[i] = random.Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = random.Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < arr.GetLength(0); x++)
    {
        for (int y = 0; y < arr.GetLength(1); y++)
        {
            for (int z = 0; z < arr.GetLength(2); z++)
            {
                arr[x, y, z] = temp[count];
                count++;
            }
        }
    }
}

void PrintArray(int[,,] arr)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                Console.Write($"{arr[i, j, k]} ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}

if (x * y * z >= 100)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("На заполнение массива не хватит двузначных чисел, так-как они все используются!");
    Console.ForegroundColor = ConsoleColor.White;
    return;
}
else
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Использованно {x * y * z} чисел из 90 возможных!");
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine();
}

FillArray(array);

Console.WriteLine("Сгенерированы следующие цифры в массиве:");
Console.WriteLine();
PrintArray(array);

Console.WriteLine("Массив с индексами: ");
Console.WriteLine();
PrintArrayAndIndex(array);