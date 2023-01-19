// №8 Напишите программу, которая на вход принимает число (N), а на выходе показывает
// все чётные числа от 1 до N.

Console.Write("Введите число: ");

string? num = Console.ReadLine();
//проверяем
if (num != null)
{
    //парсим 
    int numInt = int.Parse(num);
    //объявляем rezult
    string rezult = string.Empty;
    for (int i = 2; i <= numInt; i = i + 2)
    {//выводим все четные числа в rezult
        rezult = rezult + i + ", ";
    }
   
    rezult = rezult.Remove(rezult.Length - 2);
    
    Console.WriteLine(rezult);
}