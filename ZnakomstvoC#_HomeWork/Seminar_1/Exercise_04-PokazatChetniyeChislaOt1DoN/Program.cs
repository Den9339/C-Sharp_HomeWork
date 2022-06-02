// Показать четные числа от 1 до N
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int a = 1;
while(a <= n)
{
    if(a % 2 == 0)
    {
        Console.Write("Четные числа: ");
        Console.WriteLine(a);
    }
    a = a + 1;
}