int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Метод, принимает строку, выводит в консоль
void PrintResult(int numberM,int numberN )
{
    if  (numberM< numberN) 
    {
       Console.WriteLine($"Сумма в промежутке M...N = {SumRecMN(numberM,numberN)}");
    }
    if (numberM> numberN) 
    {
        Console.WriteLine ( $"Сумма в промежутке M...N = {SumRecMN(numberN, numberM)}");
    }
}

int SumRecMN(int numberM, int numberN)
{
    if (numberM >= numberN) return numberN;
   return  numberM + SumRecMN(numberM + 1, numberN);
}


int numberM = ReadData("Введите числа M: ");
int numberN = ReadData("Введите числа N: ");

PrintResult(numberM, numberN);