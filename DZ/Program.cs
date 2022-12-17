// Задача 54

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

void ArrangeMatrix(int[,] matrix)
{
    int count = 0;
    int bufer = 0;
    while (count < matrix.GetLength(0))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    bufer = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = bufer;
                }
            }
        }
        count++;
    }
}

// Задача 56

void FindStringOfMinSumm(int[,] matrix)
{
    int[] sum = new int[matrix.GetLength(0)];
    int minSum = 0;
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            sum[i] += matrix[i, j];
        if (i == 0)
            minSum = sum[i];
        else if (minSum > sum[i])
        {
            minSum = sum[i];
            count = i;
        }
    }
    System.Console.WriteLine($"{count + 1}-я строка с наименьшей суммой элементов");
}

// Задача 60

void Fill3DMatrix(int[,,] matrix)
{
    int number = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(2); n++)
            {
                matrix[i, j, n] = number;
                number++;
                System.Console.Write($"{matrix[i, j, n]}({i},{j},{n}) \t");
            }
            System.Console.WriteLine();
        }
    }
}


Console.Clear();
System.Console.WriteLine("Создаём 2Д матрицу \nВведите размеры матрицы через пробел: ");
string[] index = Console.ReadLine().Split(" ");
int[,] myMatrix = new int[int.Parse(index[0]), int.Parse(index[1])];
FillMatrix(myMatrix);
PrintMatrix(myMatrix);
System.Console.WriteLine();
System.Console.WriteLine("Матрица, упорядоченная по убыванию");
ArrangeMatrix(myMatrix);
PrintMatrix(myMatrix);
System.Console.WriteLine();
FindStringOfMinSumm(myMatrix);
System.Console.WriteLine();
System.Console.WriteLine("Создаём 3Д матрицу с неповторяющимися двузначными числами \nВведите размеры через пробез: ");
string[] index2 = Console.ReadLine().Split(" ");
int[,,] matrix3d = new int[int.Parse(index2[0]), int.Parse(index2[1]), int.Parse(index2[2])];
Fill3DMatrix(matrix3d);
