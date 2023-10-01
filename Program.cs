// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
/*
Console.Write("Enter number A: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter degree B: ");
int B = Convert.ToInt32(Console.ReadLine());

double result = 1;

if (B >= 0)
{
    for (int i = 0; i < B; i++)
    {
        result *= A;
    }
}
else
{
    Console.WriteLine("The degree of B must be non-negative");
    return;
}

Console.WriteLine($"{A} ^ {B} = {result}");
*/
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
Console.Write("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = 0;

while (num != 0)
{
    int digit = num % 10;
    result += digit;
    num /= 10;
}

Console.WriteLine(result);
*/
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
using System;

class Program
{
    static void Main()
    {
        // Создаем массив из 8 элементов
        int[] array = new int[8];

        // Заполняем массив значениями (по вашему желанию)
        for (int i = 0; i < 8; i++)
        {
            array[i] = new Random().Next(1, 100); // Например, заполняем массив случайными числами от 1 до 99
        }

        // Выводим элементы массива на экран в квадратных скобках
        Console.Write("[");
        for (int i = 0; i < 8; i++)
        {
            Console.Write(array[i]);
            if (i < 7)
            {
                Console.Write(", "); // Добавляем запятую и пробел между элементами (кроме последнего)
            }
        }
        Console.WriteLine("]"); // Закрываем квадратные скобки и переходим на новую строку
    }
}
*/