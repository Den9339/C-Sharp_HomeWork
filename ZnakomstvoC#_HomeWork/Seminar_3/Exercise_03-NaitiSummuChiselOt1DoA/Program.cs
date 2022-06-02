// Найти сумму чисел от 1 до А
Console.Clear();
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
int i = 1;
int sum = 0;
while(i<=A)
{
    sum = i+sum;
    i++;
}
Console.WriteLine($"Сумма чисел от 1 до {A} = {sum}");