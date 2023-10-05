//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int number = new Random().Next(100, 1000);

int hundred = number / 100;
int ten = (number - hundred * 100) / 10;
// int unit = number - hundred * 100 - ten * 10;

Console.WriteLine($"{number} -> {ten}");
