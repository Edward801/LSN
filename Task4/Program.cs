﻿//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

int number = new Random().Next(10, 100);//99+1
Console.WriteLine($"случайное число из отрезка [10, 99]={number}");
int firstDigit = number / 10;
int secondDigit = number % 10;


if (firstDigit > secondDigit)
{
 Console.WriteLine($"наибольшую цифру числа {number}");
}
else
{
 Console.WriteLine($"наибольшую цифру числа {number}");
}
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit; //Тернарный оператор альтернатива if
Console.WriteLine(maxDigit);