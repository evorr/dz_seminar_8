// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m,n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(1,10);
        }
    }
    return matrix;
}


int[,] SortRowElements (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1)-1; j++) 
        {
            int maxPos = j;
            for (int k = j+1; k < matrix.GetLength(1); k++)  
            {
                if(matrix[i,k]>matrix[i,maxPos]) maxPos = k;
            }
            int temp = matrix[i,j];
            matrix[i,j] = matrix[i,maxPos];
            matrix[i,maxPos] = temp;
        }
    }
    return matrix;
}

void PrintMatrix (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(j<array.GetLength(1)-1) Console.Write($"{array[i,j],3},");
            else Console.Write($"{array[i,j],3}");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetMatrix(3,4);
PrintMatrix(matrix);
Console.WriteLine();
int[,] matrixSort = SortRowElements(matrix);
PrintMatrix(matrixSort);
