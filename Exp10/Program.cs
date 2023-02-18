//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1


Console.WriteLine("Введите трехзначное число :  ");
int value = Convert.ToInt32(Console.ReadLine());


//int a = value / 100; // 5  div - /
int b = value / 10;
//int c = value % 10;  // 7  mod - %

int result =  b % 10 ;
Console.WriteLine(result);