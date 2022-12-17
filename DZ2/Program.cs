// Задача 58

void MyltiplicationMatrix(int[,] matr1, int[,] matr2)
{
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            System.Console.Write($"{matr1[i,j]*matr2[i,j]} \t");
        }
    System.Console.WriteLine();
    }
}

void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.Clear();
System.Console.WriteLine("Задайте размер умножаемых матриц");
string[] index = Console.ReadLine().Split(" ");
int[,] matrix1 = new int[int.Parse(index[0]),int.Parse(index[1])];
int[,] matrix2 = new int[int.Parse(index[0]),int.Parse(index[1])];
FillMatrix(matrix1);
PrintMatrix(matrix1);
System.Console.WriteLine();
FillMatrix(matrix2);
PrintMatrix(matrix2);
System.Console.WriteLine();
MyltiplicationMatrix(matrix1,matrix2);