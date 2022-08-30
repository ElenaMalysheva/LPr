// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

string NaturalNumbers(int a, int b)
{
    string result = $"{a} ";
    if (a < b)
    {
        result = result + NaturalNumbers(a + 1, b);

    }
    return result;
}

// Console.WriteLine($"Натуральные числа от {2} до {5}:  {NaturalNumbers(2, 5)}");

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int a, int b)
{
    int resultInt = a;
    if (a < b)
    {
        resultInt = resultInt + SumNumbers(a + 1, b);

    }
    return resultInt;
}

// Console.WriteLine($"Натуральные числа от {1} до {15}:  {SumNumbers(1, 15)}");



// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29


static int S(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (n > 0 && m == 0)
        return S(n - 1, 1);
    else if (n > 0 && m > 0)
        return S(n - 1, S(n, m - 1));
    else return 100000;
}


Console.WriteLine($"Функция Анкермана для n ={3}, m = {2}: {S(3,2)}");
