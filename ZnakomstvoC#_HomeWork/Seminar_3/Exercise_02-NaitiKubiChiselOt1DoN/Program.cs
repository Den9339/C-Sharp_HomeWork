// Найти кубы чисел от 1 до N
Console.Clear();
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
while(i<=N)
{
    int cube = i*i*i;
    Console.WriteLine($"Куб числа {i} = {cube} ");
    i++;
}
