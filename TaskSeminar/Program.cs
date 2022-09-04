/*Задача 55: Задайте двумерный массив. Напишите программу, 
которая заменяет строки на столбцы. В случае, если это невозможно, 
программа должна вывести сообщение для пользователя
using static System.Console;
Clear();
int colums = Convert.ToInt32(ReadLine());
int rows = Convert.ToInt32(ReadLine());
int[,]  Arra = GetMatrixArray(rows, colums, 10, 20);
if(colums == rows)
{
PrintMatrixArray(Arra);
//NewMatrix(Arra);
//WriteLine();
//PrintMatrixArray(Arra);
}
else WriteLine("It's a boolshit");
int[,] GetMatrixArray(int rows,int colums, int minValue, int maxValue)
{
   int[,] result=new int[rows,colums];
   for (int i = 0; i < rows; i++)
   {
        for (int j = 0; j < colums; j++)
        {
            result[i,j]=new Random().Next(minValue,maxValue+1);
        }
   }
   return result;
}
void PrintMatrixArray(int[,] inArray)
{
   for (int i = 0; i < inArray.GetLength(0); i++)
   {
      for (int j = 0; j < inArray.GetLength(1); j++)
      {
          Write($"{inArray[i,j]} ");
      }
    WriteLine();
   }
}
void NewMatrix(int[,] matt)
{
       for (int i = 0; i < matt.GetLength(0); i++)
       {
           
        for (int j = 0; j < matt.GetLength(1); j++)
        {   
         
                        
            int temp = matt[1, j];
            matt[1, j] = matt[ i, 1]; 
            matt[matt.GetLength(0)-1 , j] = temp;
            
            
        }    
     }
}
*/
using static System.Console;
Clear();

int[,] arr = GetMatrixArray(5, 5, 10, 99);

if (arr.GetLength(0) != arr.GetLength(1))
{
    WriteLine("It's a boolshit"); return;
}
PrintMatrixArray(arr);
arr = arrSwap(arr);



WriteLine();
PrintMatrixArray(arr);
int[,] GetMatrixArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();

    }
}
int[,] arrSwap(int[,] arr)
{
    int[,] result = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            result[j, i] = arr[i, j];
        }
    }
    return result;
}




/*Задача 53: Задайте двумерный массив. Напишите программу,
 которая поменяет местами первую и последнюю строку массива.*/

using static System.Console;
Clear();

int[,] Arra = GetMatrixArray(3, 4, 10, 20);

PrintMatrixArray(Arra);
NewMatrix(Arra);
WriteLine();
PrintMatrixArray(Arra);




int[,] GetMatrixArray(int rows, int colums, int minValue, int maxValue)


{
    int[,] result = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

void NewMatrix(int[,] matt)
{

    for (int j = 0; j < matt.GetLength(1); j++)
    {
        int temp = matt[0, j];
        matt[0, j] = matt[matt.GetLength(0) - 1, j]; //под вопросом
        matt[matt.GetLength(0) - 1, j] = temp;
    }

}



/*Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том,
 сколько раз встречается элемент входных данных.*/


using static System.Console;
using System.Linq;
Clear();
WriteLine("Enter array parameters: ");
int[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
int[,] array = GetMatrix(parameters[0], parameters[1], parameters[2], parameters[3]);
PrintMatrix(array);
WriteLine();
int[] rowArray = GetRowArray(array);//.OrderBy(x=>x).ToArray();
SortArray(rowArray);
WriteLine(String.Join(" ", rowArray));
PrintData(rowArray);



int[,] GetMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int[] GetRowArray(int[,] inArray)
{
    int[] result = new int[inArray.GetLength(0) * inArray.GetLength(1)];
    int k = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result[k] = inArray[i, j];
            k++;
        }
    }
    return result;
}

void SortArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        for (int j = i + 1; j < inArray.Length; j++)
        {
            if (inArray[i] > inArray[j])
            {
                int temp = inArray[i];
                inArray[i] = inArray[j];
                inArray[j] = temp;
            }
        }
    }
}

void PrintMatrix(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}

void PrintData(int[] inArray)
{
    int el = inArray[0];
    int count = 1;

    for (int i = 1; i < inArray.Length; i++)
    {
        if (el != inArray[i])
        {
            WriteLine($"{el}-->{count};");
            el = inArray[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    WriteLine($"{el}-->{count};");
}