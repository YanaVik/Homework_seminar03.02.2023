﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[row, col];

void FillarrayayRandomNumbers(int[,] arrayay)
{
    for (int i = 0; i < arrayay.GetLength(0); i++)
    {
        for (int j = 0; j < arrayay.GetLength(1); j++)
        {
            arrayay[i, j] = Convert.ToInt32(new Random().Next(-100, 100));
        }
    }
}

void Printarrayay(int[,] arrayay)
{
    for (int i = 0; i < arrayay.GetLength(0); i++)
    {
        for (int j = 0; j < arrayay.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,8}",arrayay[i, j]));
        }
        Console.WriteLine();
    }
}

FillarrayayRandomNumbers(array);
Printarrayay(array);

Console.Write("Введите строку: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите столбец: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;

if (pos1 < 0 | pos1 > array.GetLength(0) - 1 | pos2 < 0 | pos2 > array.GetLength(1) - 1)
{
    Console.WriteLine("Элемент не существует  ");
}
    else
{
    Console.WriteLine("Значение элемента массива = {0}", array[pos1, pos2]);
}