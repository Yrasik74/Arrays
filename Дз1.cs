﻿//Задайте массив на 10 целых чисел. Напишите программу,
// которая определяет количество чётных чисел в массиве.

using System;

class Program
{
static void Main()
{
int[] array = { 4, 7, 12, 15, 20, 23, 28, 31, 36, 40 }; // задаем массив из 10 целых чисел

int count = 0;

for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0) // если число чётное
{
count++; // увеличиваем счетчик чётных чисел
}
}

Console.WriteLine("Количество чётных чисел в массиве: " + count);
}
}