// По двум заданным числам проверять является ли первое квадратом второго
Console.WriteLine("Введите число 1: ");
int chislo_1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int chislo_2 = int.Parse(Console.ReadLine());
if(chislo_2 == chislo_1 * chislo_1)
{
    Console.WriteLine("Число 2 является кваратом числа 1");
}
else
{
    Console.WriteLine("Число 2 не является кваратом числа 1");
}
