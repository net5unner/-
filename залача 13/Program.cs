// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.Clear();

Console.WriteLine("Введите число: ");

int num = int.Parse(Console.ReadLine());

if(num < 100) 
{
Console.WriteLine("В этом числе 3яя цифра отсутствует");
}
while (num >= 100)
{
    if (num < 1000)
{
    int N3 = num % 10;
    Console.WriteLine("Третья цифра в числе: "+ N3);
}
num = num / 10;
}
