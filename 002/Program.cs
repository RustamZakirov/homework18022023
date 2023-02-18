// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет
// 1 2 -> На данной позиции находиться элемент 4



void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = Math.Round((new Random().Next(-99,100) + new Random().NextDouble()), 2);
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

Console.Clear();
Console.Write("Введите размер массива: ");
double[] size = Console.ReadLine().Split().Select(x => double.Parse(x)).ToArray();
double[,] matrix = new double[(int)size[0], (int)size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.Write("Введите искомую позицию: ");
int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int a = input[0];
int b = input[1];
if ( (a) > (matrix.GetLength(0)) || (b) > (matrix.GetLength(0)))
    Console.Write("такой позиции в массиве нет");
else
    Console.Write($"На данной позиции находиться элемент: {matrix[(a - 1), (b - 1)]} \t");
