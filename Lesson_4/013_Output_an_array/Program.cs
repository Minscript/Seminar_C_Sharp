Console.Clear();
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

/*Задаёт кто: Пользователь или программа? Сделал 2 варианта: в ручную и с автозаполнением */

Console.Write("Программа может создать число за вас! \nВведите \"1\", чтобы программа ввела числа за вас. \nВведите \"0\" или любое другое число, чтобы ввести вручную! \n\nВключить автозаполнение: ");

bool AutoFill()
{
    int response = Convert.ToInt32(Console.ReadLine());
    if (response == 1)
    {
        Console.WriteLine("\nВключено автозаполнение!");
        return true;
    }
    else
    {
        return false;
    }
}

// Включить автозаполнение?
bool autofill = AutoFill();

// Создаём массив
int[] array = new int[8];

// Создаём рандом
Random random = new Random();

// Метод рандомизации массива
int[] GetRandom(int[] arr)
{
    int[] inarray = arr;
    for (int i = 0; i < inarray.Length; i++)
    {
        inarray[i] = random.Next(1, 10);
    }
    return inarray;
}

// Метод ручного заполнения массива
int[] GetArray(int[] arr)
{
    int[] inarray = arr;
    for (int i = 0; i < inarray.Length; i++)
    {
        Console.Write($"\nВведите {i + 1} число: ");
        inarray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return inarray;
}

// Заполнение массива
if (autofill == true)
{
    array = GetRandom(array);
}
else
{
    array = GetArray(array);
}

// Метод вывода массива
void PrintArray(int[] arr)
{
    Console.Write("\nМассив чисел: [");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i + 1 < arr.Length)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.Write($"{arr[i]}]");
        }
    }
}

PrintArray(array);

// Под конец задания понял что программа должна задать сама себе массив. Ну думаю ручной ввод не будет лишним