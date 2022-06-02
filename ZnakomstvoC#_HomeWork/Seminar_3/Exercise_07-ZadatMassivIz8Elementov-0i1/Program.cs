// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
/*Console.Clear();
int[] array = {1,0,0,1,0,1,1,0};
for(int i=0; i<array.Length; i++) Console.Write($"{array[i]} ");*/

Console.Clear();
int[] array = new int[8];
Random rand = new Random();
for(int i = 0; i < array.Length; i++) 
{
    array[i] = rand.Next(0, 2); 
    Console.Write($"{array[i]} "); 
}
    



     
     

