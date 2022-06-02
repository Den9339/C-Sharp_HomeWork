// Возведите число А в натуральную степень B используя цикл
Console.Clear();
Console.WriteLine("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа A: ");
int B = int.Parse(Console.ReadLine());
int i = 1;
int degree = 0;
while(i<=B)
{
    degree = Convert.ToInt32(Math.Pow(A, i));
    i++;
}
Console.WriteLine();
Console.WriteLine($"{B} степень числа {A} = {degree}");

