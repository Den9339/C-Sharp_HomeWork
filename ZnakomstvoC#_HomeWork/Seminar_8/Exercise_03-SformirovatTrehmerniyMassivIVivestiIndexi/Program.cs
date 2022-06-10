/*Сформировать трехмерный массив не повторяющимися двузначными числами +
показать его построчно на экран выводя индексы соответствующего элемента*/
void PrintIndexMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
                Console.WriteLine($"Индекс ({i} {j} {k}) соответствует элементу {matrix[i, j, k]} в массиве ");
        }
    }

}
void FillMatrix(int[,,] matrix)
{
    int fill = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (fill < 100)
                {
                    matrix[i, j, k] = fill;
                    fill++;
                }
            }
        }
    }
}

Console.Clear();
Console.WriteLine("Введите размер трехмерного массива: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int k = int.Parse(Console.ReadLine());
int[,,] matrix = new int[m, n, k];
FillMatrix(matrix);
PrintIndexMatrix(matrix);
Console.WriteLine();

