// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int DataEntry(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void From1ToN(int N)
{
    if(N>0)
    {
    System.Console.Write($"{N} ");
    From1ToN(N-1);
    }
}

int N = DataEntry("Задайте значение N");
System.Console.WriteLine($"Все натуральные числа в промежутке от 1 до {N}:");
From1ToN(N);