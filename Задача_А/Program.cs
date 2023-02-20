// Задача_а_Подсчитать сумму цифр в числе.

Console.Clear();

Console.WriteLine("Введите любое число: ");

int num = int.Parse(Console.ReadLine()!);

int sum =0;
while (num > 0)
{
sum = sum + num % 10;
num /= 10;
}
Console.WriteLine($"Сумма цифр числа равна {sum}");
