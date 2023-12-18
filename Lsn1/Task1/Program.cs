//Напишите программу, которая на вход принимает два 
//целых числа и проверяет, является ли первое число квадратом второго.
// a = 25, b = 5  => да
// a = 2,  b = 10 => нет
// a = 9,  b = -3 => да
// a = -3, b = 9  => нет
//1. Получить 2 числа?
//2. Определить квадрат числа?
//3. Необходимо проверить...

Console.WriteLine("Введите число a");
string strA = Console.ReadLine();
int a = Convert.ToInt32(strA);

                                //int a = 16;

Console.WriteLine("Введите число b");
string strB = Console.ReadLine();
int b = Convert.ToInt32(strB);


                                //int b = 4;

int c = b * b;

 if(a == c)  {                // if (условие) {тело, которое относится к данному условию} 
    Console.Write("Да");
} else {
    Console.Write("Нет");
}                             // a = 5, (a == 5) => правда/ложь
