/* Задайте двумерный массив из целых чисел.
 Найдите среднее арифметическое элементов в каждом столбце.*/

int rows = new Random().Next(1,10);
int columns = new Random().Next(1,10);

int[,] array = GetArray(rows, columns, 0, 20);
PrintArray(array);
Console.WriteLine();

double[] arithmeticMean = ArithmeticMeanByColumns(array);
PrintArrayDouble(arithmeticMean);

int[,] GetArray(int rows, int columns, int min, int max)
{
    int[,] result = new int [rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i,j] = new Random().Next(min,max);
        }
    }
    return result;
}

void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintArrayDouble(double[] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write($"{array[i]} ");
    }
}

double[] ArithmeticMeanByColumns(int [,] array)
{
    double[] result = new double [array.GetLength(1)];
    double sum = 0;
    for(int i = 0; i < array.GetLength(1); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j,i];
        }
        result[i] = sum / array.GetLength(0);
        result[i] = Math.Round(result[i], 2);
        sum = 0;
    }
    return result;
}

