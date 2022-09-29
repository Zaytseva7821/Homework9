// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int DataEntry(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Ackermann (int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    if (n == 0)
    {
        return Ackermann(m-1, 1);
    }
    return Ackermann(m-1, Ackermann(m, n-1));
}
int м = DataEntry("Введите значение m");
int n = DataEntry("Введите значение n");
System.Console.WriteLine($"A({m},{n}) = {Ackermann(m,n)}");
