// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
Console.Clear();
Console.WriteLine("Введите размер массива: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[number];
Random rand = new Random();
int count_odd = 0;
int count_even = 0;
int i=0; 
while(i<number) 
{
    array[i] = rand.Next(100, 1000);
    Console.Write($"{array[i]} ");
    if(array[i]%2 != 0) count_odd = count_odd + 1;
    else if(array[i]%2 == 0) count_even = count_even + 1;
    i++;
}
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в массиве = {count_even}");
Console.WriteLine($"Количество нечетных чисел в массиве  = {count_odd}");
