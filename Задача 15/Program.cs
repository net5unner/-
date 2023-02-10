// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.

Console.Clear();

string[] Неделя = {"Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс"};

Console.WriteLine("Ввести цифру, обозначающую день недели: ");

int Num = int.Parse(Console.ReadLine()!);

int Day = Num - 1;

if (Day < Неделя.Length)
{
    if (Num <= 5)
    {
        Console.WriteLine("Это рабочий день");
    }
    else
    {
        Console.WriteLine("Это выходной");
    }
}
else
{
Console.WriteLine("День недели не существует");


}