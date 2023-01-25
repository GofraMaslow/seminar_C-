// Задача 19

int num = TakeData("Введите пятизначное число: "); // ввод

while (num<10000 || num>99999){ // Проверяем 
    Console.WriteLine("Вы ввели не пятизначное число!");
    num = TakeData("Введите пятизначное число: ");
}

var palindromes = new Dictionary<int, string>(); //  словарь palindromes

int leftDigits = 10; 
int midDigit = 0; 
string rightDigits = "00"; 
int newPalindrom=0; 

while (leftDigits<=99){ // цикл 
    rightDigits=(leftDigits%10).ToString()+(leftDigits/10).ToString(); // расчет
    midDigit=0; // обнуляем среднее число
    while (midDigit<=9){ // цикл      
        newPalindrom=int.Parse(leftDigits.ToString()+midDigit.ToString()+rightDigits); // собираем все вместе
        palindromes.Add(newPalindrom, "Число является палиндромом");
        midDigit++; 
    }
    leftDigits++;
}


string? msg ="a"; 

if (palindromes.TryGetValue(num, out msg)){ 
    Console.WriteLine(msg);  // выводим полученное из словаря 
}
else{
    Console.WriteLine("Число не является палиндромом"); // Если в словаре не найдено 
}



int TakeData (string msg) { 
    Console.Write(msg);
    return int.Parse(Console.ReadLine()??"0");
} 