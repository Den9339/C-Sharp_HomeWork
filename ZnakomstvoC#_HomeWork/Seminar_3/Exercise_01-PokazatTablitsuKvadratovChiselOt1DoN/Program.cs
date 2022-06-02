// Показать таблицу квадратов чисел от 1 до N
Console.Clear();
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
while(i<=N)
{
    int Square = i*i;
    Console.WriteLine($"Квадрат числа {i} = {Square} ");
    i++;
}