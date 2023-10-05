//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите номре дня недели: ");
string s = Console.ReadLine();
int number;

if (int.TryParse(s, out number) && number > 0 && number < 8)
{
    if (number > 5)
    {
        Console.WriteLine($"{number} -> да");
    }
    else
    {
        Console.WriteLine($"{number} -> нет");
    }
}
else
{
    Console.WriteLine("Введено некорректное число");
}
