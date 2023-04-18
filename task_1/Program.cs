// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReadInt(string messege)
{
    Console.Write($"{messege} > ");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int x)
{
    if (x < 9999 || x > 100000)
    {
        Console.WriteLine("Данное число не является пятизначным");
        return false;
    }
    return true;
}

string BePalind(int number)
{
    int a1 = number / 10000 % 10;
    int a2 = number / 1000 % 10;
    int a4 = number / 10 % 10;
    int a5 = number % 10;
    if (a1 == a5 && a2 == a4)
    {
        Console.Write($"Число {number} ");
    }
    else
    {
        Console.Write($"Число {number} не ");
    }
    return $"является полиндромом";
}

int n = ReadInt("Введите пятизначное число");
if (Validate(n))
{
    Console.WriteLine(BePalind(n));
}

