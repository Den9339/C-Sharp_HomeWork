// Показать кубы чисел, заканчивающихся на четную цифру
Console.Clear();
Console.WriteLine("Введите конечное число: ");
int A = int.Parse(Console.ReadLine());
int i = 1;
int last_digit = 0;
while(i<=A)
{
    last_digit = i % 10;
    Console.WriteLine($"Текущее число: {i}");
    Console.WriteLine($"Последняя цифра текущего числа: {last_digit}");
    if(last_digit % 2 == 0)
    {
        Console.WriteLine($"Куб числа, заканчивающегося на четную цифру: {Convert.ToInt32(Math.Pow(i, 3))}");
        Console.WriteLine();
    }
    if(last_digit % 2 != 0)
    {
        Console.WriteLine("Число заканчивается на нечетную цифру, введите другое число.");
        Console.WriteLine();
    }
    i++;
}