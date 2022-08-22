//Задача 62. Заполните спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    int c=1;
    int count=0;
    while (c<=matrix.Length)
    {
        for (int j = 0+count; j <= n-1-count; j++)
        {
            matrix[0+count,j]=c;
            c=c+1;
        }
        for (int i = 1+count; i < n-count; i++)
        {
            matrix[i,n-1-count]=c;
            c=c+1;
        }
        for (int j = n-2-count; j>=0+count; j--)
        {
            matrix[n-1-count,j]=c;
            c=c+1;
        }
        for (int i=m-2-count; i>0+count; i--)
        {
            matrix[i,0+count]=c;
            c++;
        }
        count++;
    }
    return matrix;
}

int[,] matrix = GetMatrix(4,4);

void PrintMatrix (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j<array.GetLength(1)) Console.Write($"{array[i,j].ToString("00"),3}");
        }
        Console.WriteLine();
    }
}
PrintMatrix(matrix);



