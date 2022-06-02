// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.Clear();
Console.WriteLine("Введите количество элементов массива: ");
int numb = int.Parse(Console.ReadLine());
int[] array = new int[numb]; //{1,2,3,4,5,6,7,8}; 
//int numb = array.Length;
Random rand = new Random();
int proizv = 1;
for(int i=0; i<numb; i++) 
{
    array[i] = rand.Next(0,10);
    Console.Write($"{array[i]} ");

}
for(int i=0; i<numb; i++)
{
    proizv = array[i] * array[numb-1];
    numb = numb - 1;
    Console.WriteLine();
    Console.Write($"Поизведение = {proizv} ");
}