//Задача 58: Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

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

int[,] MatrixMultiplication (int[,] matrixA, int [,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0),matrixB.GetLength(1)];
   for (int k = 0; k < matrixC.GetLength(0); k++)
   {
        for (int i = 0; i < matrixC.GetLength(0); i++)
        {
            for (int j = 0; j < matrixC.GetLength(1); j++)
            {
                matrixC[i,j] += (matrixA[i,k]*matrixB[k,j]);
            }
        }
   }
      
    return matrixC;
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



int[,] matrixA = GetMatrix(2,2);
int[,] matrixB = GetMatrix(2,2);

PrintMatrix(matrixA);
Console.WriteLine();
PrintMatrix(matrixB);
Console.WriteLine();
int[,] matrixC = MatrixMultiplication(matrixA,matrixB);
PrintMatrix(matrixC);