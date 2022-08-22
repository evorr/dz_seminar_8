//Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
//двузначных чисел. Напишите программу, которая будет 
//построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int[,,] GetMatrix(int m, int n, int k)
{
    int[,,] matrix = new int[m,n,k];
    int d = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int l = 0; l < matrix.GetLength(2); l++)
            {
                matrix[i,j,l] = d;
                d++;
            }
            
        }
    }
    return matrix;
}

int[,,] matrix = GetMatrix(2,2,2);

void PrintMatrix (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(k<array.GetLength(1)-1) Console.Write($"{array[i,j,k],3} ({i},{j},{k}),");
                else Console.Write($"{array[i,j,k],3} ({i},{j},{k})");
            }
            Console.WriteLine();
        }
    }
}

PrintMatrix(matrix);
