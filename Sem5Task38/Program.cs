
double [] FillArray (int arrLength, int arrMaxNum, int arrMinNum)
 {
    Random rand = new Random(); //Генератор 
    double[] array = new double[arrLength];

    for (int i = 0; i < arrLength; i++) // проходим по всему массиву
    {
        array[i] = Math.Round (rand.NextDouble() *100,2);
    }
    return array;
 }
void Print1DArray(double[] arr)
 {
     Console.Write("[" + arr[0] + ", ");
     for (int i = 1; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ",");
    }
     Console.WriteLine(arr[arr.Length - 1] + "]");
     Console.WriteLine();
 }
// считаем  между min и мах разницу
double MaxMin (double[] arr)
{
   double махNum = int.MinValue;
   double minNum =  int.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
         if (arr[i] > махNum) 
         {
         махNum  = arr[i]; 
         }
        if (arr[i] < minNum )
        {
        minNum = arr[i];
        }
    }
   return (махNum  - minNum); // возвращает разницу между мах и min значением
}

void PrintData(string line)
 {
    Console.WriteLine(line);
 }
double[] array = FillArray (20,10,2);
Print1DArray (array); 
double sumArray = MaxMin (array); 
PrintData ("Разница максимального и минимального элементов: " + sumArray);