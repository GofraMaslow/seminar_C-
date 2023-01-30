// Задача 25
int ReadData(string line) 
{
    // выводим сообщение
Console.WriteLine(line);
    //считываем число
int number = int.Parse(Console.ReadLine() ?? "0");
    // возвращаем значение
return number;
}
// степень. Указываем два числа. Так как результат возведения в степень получится длинным, указваем long
long Pow (int numA, int numB) 
{
long res = 1; // создаем переменную, 
for (int i = 0; i < numB; i++) // тут * столько раз сколько число В
res = res * numA;
return res; // возвращаем результат переменной long res
}
void PrintData (long line)
{
Console.WriteLine(line);
}
// программу 
int numA = ReadData ("Введите число: ");
int numB = ReadData ("Введите степень: ");
long numPow = Pow (numA, numB);
PrintData (numPow);