// Задача 60
/*
.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
int[,,] arr = FillArray();

PrintArray(arr);


int[,,] FillArray()
{
    int[,,] arr = new int[2, 2, 2];
    arr[0, 0, 0] = 66;
    arr[0, 1, 0] = 25;
    arr[1, 0, 0] = 34;
    arr[1, 1, 0] = 41;
    arr[0, 0, 1] = 27;
    arr[0, 1, 1] = 90;
    arr[1, 0, 1] = 26;
    arr[1, 1, 1] = 55;

    return arr;
}

void PrintArray(int[,,] arr)
{
    for (int k = 0; k < arr.GetLength(0); k++)
    {
        //string str = string.Empty;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            string str = string.Empty;
            for (int j = 0; j< arr.GetLength(2); j++)
            {
                str += $"{arr[i, j, k]}({i},{j},{k})  ";
            }
            Console.WriteLine(str);
        }    

    }
}
