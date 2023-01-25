// Задача 23


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
// печатаем результат
void PrintData(string up, string down)
{
    Console.WriteLine(up);
    Console.WriteLine(down);
}
//выполняем метод построение 2х точек с результата
string LineBuilder(int n, int p)
{

    string s = "";
    for (int i = 1; i <= n; i++)
    {
        //вычисляем от 1 до введеного пользователем числа n
        s += Math.Pow(i, p).ToString() + "\t";
    }
    return s;
}

int n = ReadData("Введите чило N: ");
//вводим данные в метод LineBuilder
string up = LineBuilder(n, 1);
//второй в кубе
string down = LineBuilder(n, 3);

PrintData(up, down);