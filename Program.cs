﻿//Задача 3: Задайте массив из вещественных чисел с ненулевой дробной частью.
// Найдите разницу между максимальным и минимальным элементов массива.

using System;

class Program
{
static void Main()
{
double[] array = { 3.2, 1.8, 5.5, 4.6, 2.1, 6.7 }; // задаем массив из вещественных чисел

double min = array[0];
double max = array[0];

for (int i = 1; i < array.Length; i++)
{
if (array[i] < min)
{
min = array[i];
}
else if (array[i] > max)
{
max = array[i];
}
}

double difference = max - min;
Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
}
}
