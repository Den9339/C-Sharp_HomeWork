// Подсчитать сумму цифр в числе
Console.Clear();
Console.WriteLine("Введите число: ");
int chislo = int.Parse(Console.ReadLine());
int digit = 0;
int digit_sum = 0;
while(chislo*10 / 10 != 0)
{
    digit = chislo % 10;
    Console.WriteLine($"Число состоит из цифры: {digit}");
    digit_sum = digit_sum  + digit;
    chislo = chislo / 10;
}
Console.WriteLine();
Console.WriteLine($"Сумма цифр в числе = {digit_sum}");