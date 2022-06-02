// Удалить вторую цифру трёхзначного числа
Console.WriteLine("Введите трехзначное число: ");
int chislo = int.Parse(Console.ReadLine());
if(100 <= chislo && chislo <= 999)
{
    int cifra_3 = chislo % 10;
    int cifra_2 = chislo / 10 % 10;
    int cifra_1 = chislo / 100;
    Console.Write("После удаления второй цифры получается число: ");
    Console.Write(cifra_1);
    Console.Write(cifra_3);

}
else
{
    Console.Write("Введите трехзначное число!");
}
