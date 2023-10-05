//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число: ");
string s = Console.ReadLine();
int number;

if (int.TryParse(s, out number))
{
    if(number % 2 == 0)
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
    Console.WriteLine("Введено не число");
}