//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.Write("Введите первое число: ");
string s = Console.ReadLine();
int firstNumber;
int secondNumber;
int thirdNumber;

if (int.TryParse(s, out firstNumber))
{
    Console.Write("Введите второе число: ");
    s = Console.ReadLine();

    if (int.TryParse(s, out secondNumber))
    {
        Console.Write("Введите третье число: ");
        s = Console.ReadLine();

        if (int.TryParse(s, out thirdNumber))
        {
            int max;

            if (firstNumber >= secondNumber)
            {
                max = firstNumber;
            }
            else
            {
                max = secondNumber;
            }

            if(max < thirdNumber) max = thirdNumber;

            Console.WriteLine($"{firstNumber}, {secondNumber}, {thirdNumber} -> {max}");
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
}
else
{
    Console.WriteLine("Введено не число");
}
