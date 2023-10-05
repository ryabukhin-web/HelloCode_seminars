//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
string s = Console.ReadLine();
int firstNumber;

if (int.TryParse(s, out firstNumber))
{
    Console.Write("Введите второе число: ");
    s = Console.ReadLine();
    int secondNumber;

    if (int.TryParse(s, out secondNumber))
    {
        int max;

        if (firstNumber > secondNumber)
        {
            max = firstNumber;
        }
        else
        {
            max = secondNumber;
        }

        Console.WriteLine($"max = {max}");
    }
    else
    {
        Console.WriteLine("Введено не число");
    }
}
else
{
    Console.WriteLine("Введено не число");
}
