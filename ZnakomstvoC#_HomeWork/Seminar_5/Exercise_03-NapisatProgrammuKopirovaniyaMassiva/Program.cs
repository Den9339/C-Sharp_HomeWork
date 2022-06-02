void PrintArray(int[] array)
{
    for(int i=0; i<array.Length; i++) 
    {
        Random rand = new Random();
        array[i] = rand.Next(0,100);
        Console.Write($"{array[i]} ");
    }
    
}
// Написать программу копирования массива
Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int n = int.Parse(Console.ReadLine());
int[] arr = new int[n];
PrintArray(arr);
Console.WriteLine();

int[] arr_copy = arr;
for(int i=0; i<n; i++) Console.Write($"{arr_copy[i]} ");
    