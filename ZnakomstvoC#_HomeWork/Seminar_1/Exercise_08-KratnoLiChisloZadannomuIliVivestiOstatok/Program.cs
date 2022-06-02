// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine("Введите первоначальное число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число (для проверки кратности): ");
int b = int.Parse(Console.ReadLine());
if(a % b == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
if(a % b != 0)
{
    Console.Write("Первое число не кратно второму, остаток равен ");
    Console.Write(a % b);
}
