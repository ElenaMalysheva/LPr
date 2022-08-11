//Двумерные массивы

string[,] table = new string[2,5];

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int column = 0; column < 5; column++)
//     {
//         Console.WriteLine($"-{table[rows, column]}-");
//     }
// }



void PrintArray (int[,]matrix)
{
for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        Console.Write($"{matrix[rows, column]} ");
    }
    Console.WriteLine();
}
}

void FillArray(int[,]matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
       matr[i, j] = new Random().Next(1,10); // рэндом от 1 до 9 [1,10)
    }
}
}

int[,] matrix = new int[3,4];
// FillArray(matrix);
// PrintArray(matrix);

//________________________
// Закрашиваем рисунок

void PrintImage (int[,]matrix)
{
for (int rows = 0; rows < matrix.GetLength(0); rows++)
{
    for (int column = 0; column < matrix.GetLength(1); column++)
    {
        // Console.Write($"{matrix[rows, column]} ");
        if(matrix[rows, column] == 0) Console.Write($" ");
        else  Console.Write($"+");
    }
    Console.WriteLine();
}
}

void FillImage(int row, int col, int[,] picc)
{
    if (picc[row, col] == 0) 
    {
        picc[row, col]=1;
        FillImage(row-1, col, picc);
        FillImage(row, col-1, picc);
        FillImage(row+1, col, picc);
        FillImage(row, col+1, picc);

    }
}

int[,] pic = new int[,]
{
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 , 0, 0 },
    {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 , 0, 0 },
    {0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0 , 0, 0 },
    {0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0 , 0, 0 },
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0 , 0, 0 },
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 1 , 0, 0 },
    {0, 0, 0, 1, 0, 0, 0, 0, 0, 1, 0 , 0, 0 },
    {0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0 , 0, 0 },
    {0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0 , 0, 0 },
    {0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 , 0, 0 }

};
// PrintImage(pic);
// FillImage(6,6, pic);
// PrintImage(pic);

//
//________________________
// Факториал

int Factorial (int n)
{
    //1! = 1
    if (n == 1) return 1;
    else return n * Factorial(n-1);
}

Console.WriteLine(Factorial(3));

//________________________
// Числа Фибоначчи
// f(1) = 1
// f(2) = 1
// f(3) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n-1) + Fibonacci(n - 2);

};

for (int i = 1; i < 10; i++)
{
    Console.WriteLine(Fibonacci(i));
    
}
