//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


int number = new Random().Next(1, 10000);
int count = Convert.ToInt32(number.ToString().Length);

if (count < 3)
{
    Console.WriteLine($"{number} -> третьей цифры нет");
}
else
{
    int first = number / Convert.ToInt32(Math.Pow(10, count - 1));
    int second = (number - first * Convert.ToInt32(Math.Pow(10, count - 1))) / Convert.ToInt32(Math.Pow(10, count - 2));
    int third;
    if(count == 3) {
        third = number - first * Convert.ToInt32(Math.Pow(10, count - 1)) - second * Convert.ToInt32(Math.Pow(10, count - 2));
    } else {
        third = (number - first * Convert.ToInt32(Math.Pow(10, count - 1)) - second * Convert.ToInt32(Math.Pow(10, count - 2))) / Convert.ToInt32(Math.Pow(10, count - 3));
    }

    Console.WriteLine($"{number} -> {third}");
}
