﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11; 82 -> 10;  9012 -> 12

Console.WriteLine("Задача № 27. Сумма цифр в числе");

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int SumNumber(int numberN)
{
   int counter = Convert.ToString(numberN).Length;
   int number = 0;
   int result = 0;
   for (int i = 0; i < counter; i++)
   {
      number = numberN - numberN % 10;
      result = result + (numberN - number);
      numberN = numberN / 10;
   }
return result;
}
int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр: " + sumNumber);

