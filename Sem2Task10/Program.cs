//Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.

Console.Write("Введите число: ");
//парсим
int num = int.Parse(Console.ReadLine() ?? "0");

int length = num.ToString().Length;
//проверка
if (length == 3)
{
    //последнюю убираем 
    int res = num / 10;

    res = res % 10;
   
    Console.WriteLine("Вторая цифра : " + res);
}
else
{
    Console.WriteLine("Вы не ввели Трехзначное число!");
}