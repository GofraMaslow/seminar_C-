
int[] FillArray(int arrLength, int start, int stop)
{
    Random rand = new Random(); // случайные числа
    int[] array = new int[arrLength]; //Создаем массив
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(start, stop + 1); //Заполняем массив.Расчет.
    }
    return array; //Возвращаем результат (массив)
}

// подсчет четных чисел
int EvenCount(int[] array)
{
    int sum = 0; // переменная 
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            sum++;
    }
    return sum;
}

void Print1DArray(int[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array)); //Вывод массива через запятую
}

void PrintResult(int answer)
{
    Console.WriteLine("Количество четных элементов -> {0}", answer); 
}
int[] array = FillArray(5, 100, 999); //Вводим исходные значения для массива
Print1DArray(array); 
PrintResult(EvenCount(array)); //Печать результата