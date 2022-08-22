//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с 
//наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] FindRowElementSum (int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int rowSum = 0;
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum+=matrix[i,j];
        }
        
        array[i] = rowSum;
    }
    return array;
}

void FindMinRow(int[] array)
{
    int minPos = 0;
    int minElement = array[0];
    for (int i = 0; i < array.Length-1; i++)
    {
        if(array[i]<minElement)
        {
            minElement = array[i];
            minPos = i;
        } 
    }
    Console.WriteLine($"{minPos+1} строка - с наименьшей суммой элементов");//номер строки не с 0, а с 1, как в примере к задаче
}

int[,] matrix = GetMatrix(4,4);
PrintMatrix(matrix);
int[] array = FindRowElementSum(matrix);
FindMinRow(array);

