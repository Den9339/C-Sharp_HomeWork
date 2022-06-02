// Выяснить является ли число чётным
Console.WriteLine("Введите число: ");
int chislo = int.Parse(Console.ReadLine());
if(chislo % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}