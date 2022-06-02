// Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int chislo = int.Parse(Console.ReadLine());
if(100 <= chislo && chislo <= 999)
{
    int cifra_2 = chislo / 10 % 10;
    Console.Write("Вторая цифра трехзначного числа: ");
    Console.WriteLine(cifra_2);
}
else
{
    Console.Write("Введите трехзначное число!");
}