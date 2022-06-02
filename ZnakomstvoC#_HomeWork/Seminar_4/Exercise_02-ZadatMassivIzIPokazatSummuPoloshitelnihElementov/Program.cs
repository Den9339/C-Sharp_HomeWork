// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Console.Clear();
int[] array = new int[12];
Random rand = new Random();
int sumPlus = 0;
//int sumMinus = 0;
for(int i=0; i<array.Length; i++)
{
    array[i] = rand.Next(0,10); //если включить также заполнение отрицательнымит элементами, то делаем выборку rand.Next(-9,10)
    Console.Write($"{array[i]} ");
    if(array[i]>=0) sumPlus = array[i] + sumPlus;
    //if(array[i]<0) sumMinus = array[i] + sumMinus;
}
Console.WriteLine();
Console.WriteLine($"Сумма положительных чисел в массиве = {sumPlus}");
//Console.WriteLine($"Сумма отрицательных чисел в массиве = {sumMinus}");