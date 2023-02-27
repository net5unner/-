//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
int[] SumOfStr(int[,] inArray)
{
    int[] newArray = new int[inArray.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum += inArray[i, j];
            newArray[i] = sum;
        }
        sum = 0;
    }
    return newArray;
} 

void minSum(int[]inArray)
{
    int minNum = inArray [0];
    int numStr = 1;
    for (int i = 1; i < inArray.Length; i++)
    {
        if (minNum > inArray[i])
        {
            minNum = inArray[i];
            numStr++;
        }
    }
    Console.Write($"В строке {numStr} сумма элементов минимальная и равна {minNum}");
}

Console.Write("Введите количество строк: ");
int str = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int col = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(str, col, -9, 14);

PrintArray(array);
Console.WriteLine();
int[] NewArray = SumOfStr(array);
minSum(NewArray);
