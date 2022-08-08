// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

// void GetResult(int aa, int 45


// Console.WriteLine("Введите целое число А: "); // ввод с клавиатуры
// string aString = Console.ReadLine();
// Console.WriteLine("Введите целое число В: "); // ввод с клавиатуры
// string bString = Console.ReadLine();

// int a = int.Parse(aString);
// int b = int.Parse(bString);

// GetResult(a, b);
// __________________________________________________________

// Задача 27: Напишите программу, которая принимает на вход число
//  и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12




int GetSum(string aStrr)
{
    int lengh = aStrr.Length;

    int result = 0;
    for (int i = 0; i < lengh; i++)
    {
        

        int dopInt = (int)Char.GetNumericValue(aStrr[i]);
        result = result + dopInt;
    }
return result;
};

// Console.WriteLine("Введите целое число А: "); // ввод с клавиатуры
// string aString = Console.ReadLine();

// int a = int.Parse(aString);
// Console.WriteLine($"Сумма цифр в числе: {GetSum(aString)}");


// __________________________________________________________
// Задача 29: (необязательная) Напишите программу, которая создает массив из введенных через запятую цифр 
// и выводит этот массив на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]


string[]  GetArray(string aStr)
{
    int len = aStr.Length;

    string[] collection = new string[len];
    string element = "";
    int j = 0;

    for (int i = 0; i < len; i++)
    {
        if(aStr[i] != ',')
        {
            element = element + aStr[i];

        }
        
        else
        {
            collection[j] = element; 
            j++;
            element = ""; 
       }

    }
    collection[j] = element; 

    return collection;
};


void PrintArray (string[] array)
{
    Console.Write("Ваш массив: ");

    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine();
};


Console.WriteLine("Введите массив из введенных через запятую цифр : "); // ввод с клавиатуры
string aString = Console.ReadLine();
// string aString = "2,13,4";

// string[] aArray = aString.Split(',');

// int lenght = aString.Length;
// for (int i = 0; i < lenght; i++)

// {
//     Console.WriteLine(aString[i]);
// }
// GetArray(aString);
PrintArray(GetArray(aString));