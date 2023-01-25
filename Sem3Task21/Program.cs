// Задача 21 


int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}


void PrintData(string msg, double res)
{
    Console.WriteLine(msg + res);
}

// расстояние между точками
double CalcLen(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double res = 0;
    //вычисления
    res = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)+ Math.Pow(z1 - z2, 2));
    //вывод из метода
    return res;
}

// координаты точек
int coorX1 = ReadData("Введие координату Х1");
int coorX2 = ReadData("Введие координату Х2");
int coorY1 = ReadData("Введие координату Y1");
int coorY2 = ReadData("Введие координату Y2");
int coorZ1 = ReadData("Введие координату Z1");
int coorZ2 = ReadData("Введие координату Z2");

//вычисляем с помощю CalcLen
double len = CalcLen(coorX1, coorX2, coorY1, coorY2, coorZ1, coorZ2);
PrintData("Расстояние м-у точками:", len);