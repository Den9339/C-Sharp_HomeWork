// Показать натуральные числа от M до N, N и M заданы
void Recursion(int m, int n)
{
    if(m<n) Console.Write($"{m} ");
    if(m==n) Console.Write($"{m} ");
    if(m>n) return;
    Recursion(m+1,n);
}

Console.Clear();
int M = 2;
int N = 15;
Recursion(M,N);
