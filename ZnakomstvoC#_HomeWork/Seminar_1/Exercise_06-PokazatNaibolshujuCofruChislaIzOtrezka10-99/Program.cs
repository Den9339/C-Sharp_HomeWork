// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.WriteLine("Введите число от 10 до 99: ");
int a = int.Parse(Console.ReadLine());
if(10 <= a && a <= 99)
{
    int cifra_2 = a % 10;
    int cifra_1 = a / 10;
    if(cifra_1 > cifra_2)
    {
        Console.Write("Наибольшая цифра введенного числа равна ");
        Console.Write(cifra_1);
    }
    else
    {
        Console.Write("Наибольшая цифра введенного числа равна ");
        Console.Write(cifra_2);
    }
}
else
{
    Console.Write("Введите число от 10 до 99!");
}


