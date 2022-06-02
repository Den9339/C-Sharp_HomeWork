// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
Console.Clear();
int[] array = new int[123];
Random rand = new Random();
int count = 0;
for(int i =0; i<array.Length; i++)
{
    array[i] = rand.Next(0,1000);
    Console.Write($"{array[i]} ");
    if(array[i]>=10 && array[i]<=99) count = count + 1;
}
Console.WriteLine();
Console.Write($"Количество элементов и отрезка [10,99] = {count} ");