// Задача 62
void Spiral4x4(int[,] matrix)
{
    int count = 0; int length = matrix.GetLength(0);
    for (int i = 0; i < length; i++)
    {
        for (int j = 0; j < length; j++)
        {
            if (i == 0 || i == length - 1 || j == 0 || j == length - 1)
            {
                int x = i + 1;
                int y = j + 1;
                int num = x + y - 1;
                matrix[i, j] = y - x;
                int temp = (y - x + length) / length;
                matrix[i, j] = temp * num + Math.Abs(temp - 1) * (4 * length - 2 - num);
            }
            else if (j == 1 || j == length - 2)
            {
                int x = i + 6;
                int y = j + 6;
                int num = x + y - 1;
                matrix[i, j] = y - x;
                int temp = (y - x + length) / length;
                matrix[i, j] = temp * num + Math.Abs(temp - 1) * (4 * length + 14 - num);
            }
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = new int[4,4];
Spiral4x4(matrix);
PrintMatrix(matrix);