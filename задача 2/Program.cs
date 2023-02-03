//Задача 2. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите число А");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B");
int B = Convert.ToInt32(Console.ReadLine());

int max;
int min;

if (A > B)
{
    max = A;
    min = B;
}
else
{
    max = B;
    min = A;
    Console.WriteLine($"максимальное число {max}, минимальное число {min} ");
}
