// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7
// 2 3 5 9
// 2 4 4 8



int[,] OrderMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int[] new_int = new int[4];
        for (int j = 0, k = 0; j < array.GetLength(1); j++)
        {
            new_int[k] = array[i, j];
            k++;
        }
        SelecionArray(new_int);
        for (int j = 0, k = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new_int[k];
            k++;
        }
    }
    return array;

}

int[] SelecionArray(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;

        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
    return array;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void PrintBigArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");

        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

// Console.WriteLine("Матрица с элементами по порядку в каждой строке: ");
// PrintBigArray(OrderMatrix(matrix));



//--------------------------------------------------------------------------------
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[] GetSum(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    int sum = 0;

    for (int i = 0, k = 0; i < array.GetLength(0); i++)
    {
        sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        sumArray[k] = sum;
        Console.WriteLine($"Сумма элементов строки № {k + 1} = {sum}");
        k++;
    }
    return sumArray;
}

void GetNumberOfSpring(int[] arraySum)
{
    int min = arraySum[0];
    int numberOfString = 0;
    for (int i = 1; i < arraySum.GetLength(0); i++)
    {
        if (arraySum[i] < min)
        {
            min = arraySum[i];
            numberOfString = i;
        }
    }
    Console.WriteLine($"Номер строки с минимальной суммой элементов: {numberOfString + 1}");


}

int[,] matrix2 = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
    {5, 2, 6, 7}
};


//--------------------------------------------------------------------------------
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int[,] GetmMultiplication(int[,] array1, int[,] array2)
{
    int[,] arrayResult = new int[array1.GetLength(0), array1.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            arrayResult[i, j] = array1[i, j] * array2[i, j];
        }

    }
    return arrayResult;
}



int[,] matrix3 = new int[,]
{
    {1, 5, 8, 5},
    {4, 9, 4, 2},
    {7, 2, 2, 6},
    {2, 3, 4, 7}
};

// PrintBigArray(
//     GetmMultiplication(matrix2, matrix3));

//--------------------------------------------------------------------------------
// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

void FillSpiral(int i, int j, int[,] array, int k)
{
    if (j < 4 && j >= 0 && i < 4 && i >= 0)
    {
        if (k < 5)
        {
            if (array[i, j] == 0)
        {
            array[i, j] = k;
            k++;
            FillSpiral(i, j + 1, array, k);
            FillSpiral(i + 1, j, array, k);
            // FillSpiral(i, j - 1, array, k);
            // FillSpiral(i - 1, j, array, k);
            // FillSpiral(i - 1, j, array, k);

        }
        else if (k < 8)
        {
            if (array[i, 3] == 0)
        {
            array[i, 3] = k;
            k++;
            // FillSpiral(i, j + 1, array, k);
            FillSpiral(i + 1, 3, array, k);
            // FillSpiral(i, j - 1, array, k);
            // FillSpiral(i - 1, j, array, k);
            // FillSpiral(i - 1, j, array, k);

        }
        }
     
    }


}}


// if (k < 5)
// {
//     if (j < 4 && j >= 0 && i < 4 && i >= 0)
//     {
//         if (array[i, j] == 0)
//         {
//             array[i, j] = k;
//             k++;
//             FillSpiral(i, j + 1, array, k);
//             FillSpiral(i + 1, j, array, k);
//             FillSpiral(i, j - 1, array, k);
//             // FillSpiral(i - 1, j, array, k);
//             // FillSpiral(i - 1, j, array, k);


//         }
//     }
// }
// else
// {
//     if (j < 4 && j >= 0 && i < 4 && i >= 0)
//     {
//         if (array[i, j] < 0)
//         {
//             array[i, j] = k;
//             k++;
//             // FillSpiral(i, j + 1, array, k);
//             // FillSpiral(i + 1, j, array, k);
//             // FillSpiral(i, j - 1, array, k);
//             FillSpiral(i - 1, j, array, k);

//         }
//     }
// }

int[,] arrayResult = new int[4, 4];
FillSpiral(0, 0, arrayResult, 1);
PrintBigArray(arrayResult);
