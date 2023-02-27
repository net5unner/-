// Задача 58_Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

Console.Clear();
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите количество строк первой матрицы: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите количеествоово столбцов первой матрицы: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(str, col, -15, 20);
int[,] secondArray = GetArray(str, col, -15, 20);
int[,] resultArray = GetArray(str, col, -15, 20);

PrintArray(array);
Console.WriteLine();
PrintArray(secondArray);
Console.WriteLine();

if (array.GetLength(0) != secondArray.GetLength(1))
{
    Console.WriteLine("Заданные матрицы не подлежат перемножению");
    return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < secondArray.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * secondArray[k, j];
        }
    }
}
Console.WriteLine("Результирующая матрица");
PrintArray(resultArray);
