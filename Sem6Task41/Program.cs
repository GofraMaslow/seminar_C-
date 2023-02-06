
int ReadData(string line)
{
    // Выводим сообщение
    Console.Write(line);
    // Считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    // Возвращаем значение
    return number;
}

// Печать результата
void PrintResult(string prefix, string data)
{
    Console.WriteLine(prefix + data);
}

// Считаем положительные числа
int Count(int m)
{
    int res = 0;
    for (int i = 0; i < m; i++)
    {
        int num = ReadData("Введите число: ");
        if (num > 0) res++;
    }

    return res;
}

PrintResult("Пользователь ввёл чисел больше ноля: ", Count(ReadData("Введите количество чисел: ")).ToString());

