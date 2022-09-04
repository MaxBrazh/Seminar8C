/* Задача 56. Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

using static System.Console;
Clear();

int m = InputNumbers("Введите количество строк в массиве: ");
int n = InputNumbers("Введите количество столбцов в массиве: ");
int range = InputNumbers("Введите диапазон от 0 до 10: ");

int[,] array = new int[m, n];
NewArray(array);
WriteArray(array);

int minSumLine = 0;
int sumLine = SumLineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = SumLineElements(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}

WriteLine($"Номер строки с наименьшей суммой элементов: {minSumLine + 1}, сумма этих элементов = {sumLine}");


int SumLineElements(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

int InputNumbers(string input)
{
    Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void NewArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write(array[i, j] + " ");
        }
        WriteLine();
    }
}