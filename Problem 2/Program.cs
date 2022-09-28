// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int DataEntry(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SumFromMToN(int M, int N, int sum)
{
    if (M>N)
    {
    System.Console.WriteLine(sum);
    }
    else
    {
    sum = sum + N;
    SumFromMToN(M,N-1,sum);
    }
}

int M = DataEntry("Задайте значение M");
int N = DataEntry("Задайте значение N");
if (N==M)
{
    System.Console.WriteLine("Заданные числа равны");
}
if (N<M)
{
    int temp = N;
    N = M;
    M = temp;
}
int sum = N-M;
SumFromMToN(M, N, 0);