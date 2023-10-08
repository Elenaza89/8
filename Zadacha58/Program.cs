
/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int[,] arrA = new int[2, 2] {   {2,4 }, 
                                {3, 2}
                            };
int[,] arrB = new int[2, 2] {       {3,4 },
                                    {3, 3}
                            };

int[,] resArr = new int[2, 2];

for (int i = 0; i < arrA.GetLength(0); i++)
{
    for (int j = 0; j < arrB.GetLength(1); j++)
    {
        int sum = 0;
        //берем массив состоящий из строки i
        int [] tempArr1 = GetRow(arrA, i);
        int[] tempArr2 = GetCol(arrB, j);
        for (int k = 0; k < arrA.GetLength(0); k++)
        { 
            sum+= tempArr1[k] *tempArr2[k];
        }

        resArr[i, j] = sum;
    }
    
}

PrintMatrix(resArr);

int[] GetCol(int[,] arr, int col)
{
    int len = arr.GetLength(0);
    int[] res = new int[len];

    for (int i = 0; i < len; i++)
        res[i] = arr[i, col];
    return res;
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
