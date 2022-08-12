// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2





// void PrintArray (int[,]matrix)
// {
//     Console.WriteLine($"Массив, заполненный случайными положительными трёхзначными числами: ");

// for (int rows = 0; rows < matrix.GetLength(0); rows++)
// {
//     for (int column = 0; column < matrix.GetLength(1); column++)
//     {
//         Console.Write($"{matrix[rows, column]} ");
//     }
//     Console.WriteLine();
// }
// }

// void FillArray(int[,]matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
// {
//     for (int j = 0; j < matr.GetLength(1); j++)
//     {
//        matr[i, j] = new Random().Next(100,1000); // рэндом от 1 до 9 [1,10)
//     }
// }
// }

// void CountNN(int[,]matr)
// {
//     int c = 0;
//     for (int i = 0; i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             if (matr[i,j] % 2 == 0)
//             {
//                 c++ ;
//             }
//         }
//     }
//     Console.WriteLine($"Количество четных чисел в массиве: {c}");

// }

// int[,] matrix = new int[3,4];
// FillArray(matrix);
// PrintArray(matrix);
// CountNN(matrix);


//_________________________________________________________________________-
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




void PrintArray (int[] matrix)
{
    Console.WriteLine($"Одномерный массив, заполненный случайными положительными  числами: ");

for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    
Console.Write($"{matrix[rows]} ");
    
}
    Console.WriteLine();

}

void FillArray(int[] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
{
 
       matr[i] = new Random().Next(0,1000); // рэндом от 1 до 9 [1,10)
    
}
}

void PrintN(int[]matr)
{
    Console.WriteLine($"Числа, которые находятся на нечетных позициях:");

    for (int i = 0; i < matr.GetLength(0); i++)
    {
       
            if (i% 2 != 0)
            {
                Console.Write($"{matr[i]} ");
            }
    }
                Console.WriteLine();


}

int[] matrix = new int[10];
// FillArray(matrix);
// PrintArray(matrix);
// PrintN(matrix);

//_________________________________________________________________________-
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


int GetMin(int[] matr, int minMatr)
{
    // int minMatr = 1000;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (matr[i] < minMatr)
        {
            minMatr = matr[i];
        }
    }
    return minMatr;

}

int GetMax(int[] matr)
{
    int maxMatr = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if (matr[i] > i)
        {
            maxMatr = matr[i];
        }
    // return maxMatr;

    }
            return maxMatr;

}


int[] matrix3 = new int[10];

FillArray(matrix3);
PrintArray(matrix3);
Console.WriteLine($"Максимальный элемент  в массиве: {GetMax(matrix3)}");
Console.WriteLine($"Минимальный элемент  в массиве: {GetMin(matrix3, GetMax(matrix3))}");
Console.WriteLine($"Разница между максимальным и минимальным элементов массива: {GetMax(matrix3) - GetMin(matrix3, GetMax(matrix3))}");
