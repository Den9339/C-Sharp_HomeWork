// Найти сумму элементов от M до N, N и M заданы
int RecursionSum(int m, int n)
{
    if (m > n) return 0;
    else
    {
        Console.Write($"{m} ");
        return m + RecursionSum(m + 1, n);
    }
}

Console.Clear();
int M = 1;
int N = 6;
Console.Write($"  |  Sum of elements from {M} to {N} = {RecursionSum(M, N)} ");
