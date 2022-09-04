/* Задача 58. Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18  */

using static System.Console;
Clear();

WriteLine("\nВведите размеры матриц и диапазон случайных значений: ");
int m = InputNumbers("Введите количество строк 1-й матрицы: ");
int n = InputNumbers("Введите количество столбцов 1-й матрицы: ");
int s = InputNumbers("Введите количество строк 2-й матрицы: ");
int p = InputNumbers("Введите количество столбцов 2-й матрицы ");
int range = InputNumbers("Введите диапазон случайных чисел от 0 до 10 ");

int[,] firstMartrix = new int[m, n];
NewArray(firstMartrix);
WriteLine($"\nFirst matrix:");
WriteArray(firstMartrix);

int[,] secomdMartrix = new int[s, p];
NewArray(secomdMartrix);
WriteLine($"\nSecond matrix:");
WriteArray(secomdMartrix);

int[,] resultMatrix = new int[m, p];

MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
WriteLine($"\nРезультат умножения первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < firstMartrix.GetLength(1); k++)
            {
                sum += firstMartrix[i, k] * secomdMartrix[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }
}

int InputNumbers(string input)
{
    Write(input);
    int output = Convert.ToInt32(ReadLine());
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