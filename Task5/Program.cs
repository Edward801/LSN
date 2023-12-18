//Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int firstDigit = number / 10;
int secondDigit = number % 10;
Console.WriteLine($"цифры {firstDigit},{secondDigit}");


