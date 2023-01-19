// №2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число
// большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
//считываем 
string? num1 = Console.ReadLine();

Console.WriteLine("Введите второе число:");
//считываем в переменную num2 
string? num2 = Console.ReadLine();
//парсим 
if (num1 != null && num2 != null)
{
    int numInt1 = int.Parse(num1);
    int numInt2 = int.Parse(num2);
    //условие сравнения 2х чисел
    if (numInt1 > numInt2)
    {
        //если первое больше чем второе выводим строку
        Console.WriteLine("Первое число больше, чем второе.");
    }
    else
    {
        //иначе выводим эту строку
        Console.WriteLine("Второе число больше, чем первое.");
    }
}