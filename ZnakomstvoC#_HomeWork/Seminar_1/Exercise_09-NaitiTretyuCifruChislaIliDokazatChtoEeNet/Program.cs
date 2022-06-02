// Найти третью цифру числа или сообщить, что её нет
Console.WriteLine("Введите число трехзначное число: ");
int a = int.Parse(Console.ReadLine());
if(a > 99 && a < 1000) 
{
    int b = a%10;
    Console.Write("Третья цифра числа: ");
    Console.Write(b);
}
if(a < 100)
{
    Console.WriteLine("Введенно число не содержит третьей цифры");
}