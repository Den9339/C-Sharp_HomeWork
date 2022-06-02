// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("Введите число 1: ");
int chislo_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int chislo_2 = int.Parse(Console.ReadLine());
if(chislo_2 == chislo_1 * chislo_1 || chislo_1 == chislo_2 * chislo_2)
{
    Console.WriteLine("Одно из чисел является кваратом другого");
}
else
{
    Console.WriteLine("Ни одно число не является кваратом другого числа");
}
