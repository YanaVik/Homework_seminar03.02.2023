// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[row, col];

void FillarrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(1, 10));
        }
    }
}

void Printarray(int[,] array)

{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,4}",array[i, j]));
        }
        Console.WriteLine();
    }
}

FillarrayRandomNumbers(array);
Printarray(array);
Console.WriteLine("------------------------------");
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
double total = Math.Round(sum / array.GetLength(0), 2);
    
    Console.Write(  $" {total} ");
}
