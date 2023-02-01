
int[] FillArray (int arrLength, int start, int stop)
 {
    int[] array = new int[arrLength]; // генератор 
    Random ren = new Random();

    for (int i = 0; i < arrLength; i++) 
    {
        array[i] = ren.Next(start, stop + 1);
    }
    return array;
 }

void Print1DArray(int[] arr)
 {
     Console.Write("[" + arr[0] + ", ");
     for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
     Console.WriteLine(arr[arr.Length - 1] + "]");
 }
// считаем сумму элементов
int EvenSumPozition (int[] arr)
 {
    int sum  = 0;
    for (int i = 1; i < arr.Length; i=i+2)// проходим только четные позиции
    {
        sum += arr[i]; 
    }
   return sum;
 }
// вывод в консоль
void PrintData(string line)
 {
    Console.WriteLine(line);
 }




int[] array = FillArray (10,-20,100);
Print1DArray (array); // печатает массив
int sumArray = EvenSumPozition (array); 
PrintData ("Сумма нечетных элементов: " + sumArray);