// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();

//Ввод данных пользователем
Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int even = Number % 2;

//Проверка данных с выводом ответа
if (even == 0){
    Console.Write($"Число {Number} - чётное!");
} else {
    Console.Write($"Число {Number} - нечётное!");
}