Console.WriteLine("Введите  трехзначное число: ");

char[] digit = Console.ReadLine().ToCharArray();

if (digit.Length > 2)
{
    Console.WriteLine("Третья цифра : " + digit[2]);
}
else
{
    Console.WriteLine("Третьей нет!");
}