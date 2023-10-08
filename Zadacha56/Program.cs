//Задача 56
/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int[,] arr = new int[3, 4] {    {1, 4, 7, 1},
                                {5, 9, 2, 3},
                                { 8,4,2,4}
                           };
int[] summArr = new int[arr.GetLength(0)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    summArr[i] = GetRow(arr, i);
}

int index = GetMinRow(summArr);

Console.WriteLine($"Наименьшая сумма в строке {index +1}");




int GetRow(int[,] arr, int row)
{
    int len = arr.GetLength(1);
    int sum = 0;

    for (int i = 0; i < len; i++)
        sum += arr[row, i];
    return sum;
}

static int GetMinRow(int[] summArr)
{

    //var min1= summArr.Min();   
    //int index1 = summArr.ToList().FindIndex(x => x == min1);
    //Console.WriteLine($" Строка {index1 +1}");

    int min = summArr[0];
    int index = 0;
    for (int i = 0; i < summArr.GetLength(0); i++)
    {
        if (summArr[i] < min)
        {
            min = summArr[i];
            index = i;
        }
    }

    return index;
}