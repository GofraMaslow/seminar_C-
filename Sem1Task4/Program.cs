// №4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из
// этих чисел.

Console.Write("Введите первое число: ");
//считываем в переменную num1 
string? num1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string? num2 = Console.ReadLine();
Console.Write("Введите третье число: ");
string? num3 = Console.ReadLine();
if (num1 != null && num2 != null && num3 != null)
{
    //парсим 
    int numInt1 = int.Parse(num1);
    int numInt2 = int.Parse(num2);
    int numInt3 = int.Parse(num3);
    //сравниваем num1 и num2 число
    if (numInt1 > numInt2)
    {
        //если num1 больше сравниваем num1 и num3
        if (numInt1 > numInt3)
        {
            //если num1 больше выводим num1
            Console.Write("Максимальное число: ");
            Console.WriteLine(numInt1);
        }
    }
    else
    { //если num1 не больше сравниваем num2 и num3
        if (numInt2 > numInt3)
        {// если верно, выводим num2
            Console.Write("Максимальное число: ");
            Console.WriteLine(numInt2);
        }

        else
        {// если не верно, выводим num3
            Console.Write("Максимальное число: ");
            Console.WriteLine(numInt3);
        }
    }
}