// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, -567, 89, 223-> 3

int  GetLen(string aStr)
{
    int len = 0;
    for (int i = 0; i < aStr.Length; i++)
    {
        if(aStr[i] != ',')
        {
            len++;
        }
    }
    return len;
}


string[]  GetArray(string aStr)
{
    int len = aStr.Length;

    string[] collection = new string[GetLen(aStr)];
    string element = "";
    int j = 0;

    for (int i = 0; i < len; i++)
    {
        if(aStr[i] != ',')
        {
            element = element + aStr[i];
        }

        else if((aStr[i] == ','))
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
    Console.WriteLine("Ваш массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine($" {array[i]}");
    }
};

void CheckElements(string[] array)
{
    int elem = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int dopInt = Convert.ToInt32(array[i]); // перевод в int
        if (dopInt > 0)
        {
            elem++ ;
        }
    }
    Console.WriteLine($"Считаем положительные числа: {elem}");

}


// Console.WriteLine("Введите массив из введенных через запятую цифр : "); // ввод с клавиатуры
// string aString = Console.ReadLine();

// PrintArray(GetArray(aString));
// CheckElements(GetArray(aString));


// -----------------------------------------------------------

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int[] StringToInt(string[] array)
{
    int[]  arrayInt= new int[2];

    for (int i = 0; i < 2; i++)
    {
        int dopInt = Convert.ToInt32(array[i]); // перевод в int
        arrayInt[i] = dopInt;
    }
    // Console.WriteLine($"Считаем положительные числа: {elem}");
return arrayInt;
}

void GetIntersection (int[] array1, int[] array2)
{
    float a = (array2[1] - array1[1]);
    float b = (array1[0]-array2[0]);

    float x = (array2[1] - array1[1]) / (array1[0]-array2[0]);
    float y = (array1[0] * x) + array1[1];
    Console.WriteLine($"Координата х: {a / b}");
    Console.WriteLine($"Координата y: {(array1[0] * (a / b)) + array1[1]}");






}


// Console.WriteLine("Введите  угловые a,b коэффициенты прямых для первой прямой: "); // ввод с клавиатуры
// string y1Str = Console.ReadLine();
// Console.WriteLine("Введите  угловые a,b коэффициенты прямых для второй прямой: "); // ввод с клавиатуры
// string y2Str = Console.ReadLine();



// string y1Str = "5,2";
// // string y2Str = "9,4";

// PrintArray(GetArray(y1Str));
// PrintArray(GetArray(y2Str));

// StringToInt(GetArray(y1Str));

// GetIntersection(StringToInt(GetArray(y1Str)),StringToInt(GetArray(y2Str)));

// -----------------------------------------------------------
