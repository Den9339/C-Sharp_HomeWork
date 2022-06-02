//Написать программу, которая обменивает элементы первой строки и последней строки
void PrintMatrix(int[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}
void FillMatrix(int[,] matr)
{
    for(int i=0; i<matr.GetLength(0); i++)
    {
        for(int j=0; j<matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10);
        }
    }
}
void ElementsChange(int[,] matr)
{
    for(int j=0; j<matr.GetLength(1); j++)
    {
        int tmp = matr[0,j];
        matr[0,j] = matr[matr.GetLength(0)-1,j];
        matr[matr.GetLength(0)-1,j] = tmp;
    }
}

Console.Clear();
Console.WriteLine("Введите размер матрицы row и column: ");
int row = int.Parse(Console.ReadLine());
int column = int.Parse(Console.ReadLine());
int[,] matrix = new int[row, column];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ElementsChange(matrix);
PrintMatrix(matrix);





/*void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
}
void ElementsChange(int[,] matrix)
{
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        int tmp = matrix[0,j];
        matrix[0,j] = matrix[matrix.GetLength(0)-1,j];
        matrix[matrix.GetLength(0)-1,j] = tmp; 
    }
}

Console.Clear();
Console.WriteLine("Введите размер матрицы: ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());
int[,] matrix = new int[m, n];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
ElementsChange(matrix);
PrintMatrix(matrix);*/
