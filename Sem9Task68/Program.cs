int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// печать результата
void PrintResult(string line)
{
    Console.WriteLine(line);
}

// сумма чисел от m до n
int AckermannFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return AckermannFunc(m - 1, 1);
    }
    else
    {
        return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
    }
}


int numM = ReadData("Введите неотрицательное число m: ");
int numN = ReadData("Введите неотрицательное число n: ");
if (numM >= 0 && numN >= 0)
{
    PrintResult($"Функция Аккермана A({numM},{numN}) = {AckermannFunc(numM, numN)}");
}
else 
{
    PrintResult("Необходимо использовать неотрицательные числа.");
}