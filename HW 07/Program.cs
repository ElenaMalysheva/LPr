//  Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9


void FillArray(float[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = (new Random().Next(-100, 100)); // рэндом от 1 до 9 [1,10)
        }
    }
}

void DevideArray(float[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = matr[i, j] / 10;
        }
    }
}


void PrintArray(float[,] matrix)
{
    Console.WriteLine($"Массив, заполненный случайными  вещественными числами: ");

    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            Console.Write($"{(matrix[rows, column])} ");
        }
        Console.WriteLine();
    }
}

int m = 3;
int n = 4;

// float[,] matrix = new float[m,n];

// FillArray(matrix);
// DevideArray(matrix);
// PrintArray(matrix);

//---------------------------------------------------------

// Задача 50. Напишите программу, которая на вход принимает позиции элемента либо значение элемента в двумерном массиве, 
//  и возвращает значение либо индекс этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет
// 4 -> такой элемент есть и его индекс 0, 1 (идеально было б найти все вхождения этого элемента)
// 2, 3 -> такой элемент есть и равен 4
// 5, 5 -> такой элемент отсутствует

void FindIndex(int[,] array, int n)
{
    int countIn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == n)
            {
                Console.WriteLine($"Такой элемест есть и его индекс: {i}, {j}");
                countIn++;
            }
        }
    }
    if (countIn == 0)
        Console.WriteLine($"Такого элемента в массиве нет");
}

void FindElementByTndex(int[,] array, int[] indexx)
{
    int i = indexx[0];
    int j = indexx[1];
    if (i > array.GetLength(0) || j > array.GetLength(1))
    {
        Console.WriteLine($"Такого элемента нет");

    }
    else
        Console.WriteLine($"Такой элемент есть он равен: {array[i, j]}");
}


int GetLen(string aStr)
{
    int len = 0;
    for (int i = 0; i < aStr.Length; i++)
    {
        if (aStr[i] == ',')
        {
            len++;
        }
    }
    return len;
}


void PrintIntArray(int[,] matrix)
{
    Console.WriteLine($"Исходный массив: ");

    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            Console.Write($"{(matrix[rows, column])} ");
        }
        Console.WriteLine();
    }
}

int[,] pic = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};


// Console.WriteLine("Введите число (1 цифра) или индекс (2 цифры через запятую) : "); // ввод с клавиатуры
// string aString = Console.ReadLine();

// PrintIntArray(pic);

// int element = 0;
// int[] indexElement = new int[2];

// if (GetLen(aString) != 1)
// {
//     element = Int32.Parse(aString);
//     FindIndex(pic, element);
// }
// else
// {
//     indexElement[0] = (int)Char.GetNumericValue(aString[0]);
//     indexElement[1] = (int)Char.GetNumericValue(aString[2]);
//     FindElementByTndex(pic, indexElement);
// }

//---------------------------------------------------------
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


void FindMediana(int[,] array)
{
    float[] newArray = new float[array.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0, k = 0; j < array.GetLength(1); j++)
        {
            newArray[k] = newArray[k] + array[i, j];
            k++;
        }
    }

    Console.WriteLine("Среднее арифметическое столбцов: ");
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        Console.Write($"{(float)newArray[i] / array.GetLength(0)} ");
    }

}




FindMediana(pic);
double[] b = new double[5];

