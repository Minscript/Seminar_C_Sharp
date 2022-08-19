// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

//Создаём таблицу кубов
void CubeCreate(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = Convert.ToInt32(Math.Pow(i, 3));
    }
}

//Создаём массив
int[] array = new int[number + 1];
CubeCreate(array);

//Вывод в консоль
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}