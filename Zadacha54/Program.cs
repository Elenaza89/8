//Задача 54
/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] arr = new int[3, 4] {    {1, 4, 7, 2}, 
                                {5, 9, 2, 3},
                                { 8,4,2,4} 
                           };
for (int i = 0; i < arr.GetLength(0); i++)
{
    int [] tempArr = GetRow(arr, i);
    int[] sortArr = Sort(GetRow( arr, i));
    SetRow(ref arr, sortArr, i);
}

PrintMatrix(arr);

void SetRow(ref int[,] arr, int[] sortArr, int row)
{
    for (int j = 0; j < arr.GetLength(1); j++)
        arr[row, j] = sortArr[j];
}



int[] GetRow( int[,] arr, int row)
{
    int len = arr.GetLength(1);
    int[] res = new int[len];

    for (int i = 0; i < len; i++)
        res[i] = arr[row, i];
    return res;
}



void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        string res = string.Empty;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            res += $"{arr[i, j]}  ";
        }
        Console.WriteLine(res);
    }
}

int[] Sort( int[] array)
{
    var len = array.Length;

    for (int i = 1; i < len-1; i++)
    {
        for (int j = 0; j < len-i ; j++)
        {
            if (array[j] < array[j + 1])
            {
                var temp = array[j];
                array[j] = array[j + 1];
                array[j + 1] = temp;
            }
        }
    }
        return array;
    
}