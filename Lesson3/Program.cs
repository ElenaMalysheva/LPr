// 1 метод: ничего не принимает - ничего не возвращает
void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1(); // вызов метода 

//  метод:  ничего не возвращает - может принимать аргументы
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2("Текст");
// Method2(msg: "Именнованый аргумент");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21("Текст", 4);
// Method21(msg: "Текст", count: 4); // явно указать какие аргументы указываем,
//  не обязательно указывать по порядку

// 3 методы которые не принимает и возвращают: необходимо указать тип данных который он возвращает

int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
//Console.WriteLine(year);

// 3. методы которые принимает и возвращают: необходимо указать тип данных который он возвращает

string Method4(int count, string text)
{
    int i = 0;
    // string result = ""; // объявляем переменную и кладем туда пустое значение
    string result =  String.Empty; // объявляем переменную и кладем туда пустое значение

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
// string res = Method4(10, "aaa");
// Console.WriteLine(res);  

// цикл  for

string Method5(int count, string text)
{
    string result =  String.Empty; 
    for (int i = 0; i < count; i++ )
    {
        result = result + text;
    }
    return result;
}
// string res = Method5(10, "z");
// Console.WriteLine(res);  

// ---------------------------------
// Задача вывода таблицы умножения на экран


    // for (int i = 2; i <= 10; i++ )
    // {
    //     for (int j = 2; j <= 10; j++ )
    //     {
    //         Console.WriteLine($"{i} * {j} = {i*j}");
    //     }   
    //      Console.WriteLine(); // разрыв
    //      }


// ---------------------------------
// Дан текст. В тексте необходимо все пробелы заменить черточками,
//маленькие буквы к заменить большими буквами К, 
// а большие буквы С заменить маленькими "с"

string text = "-Я думаю, - сказал князь, улыбаясь - что ,"
    +"ежели бы вас послали вместо вашего милого Винцегородца"
    +"вы бы взяли приступом согласие прусского короля"
    +"Вы так красноречивы. Вы дадите мне чаю?";

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty; // инициализация пустой строки
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }


    return result;     
}

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText,'к','К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText,'C','c');
// Console.WriteLine(newText);

//-------------------------------------
//Задача сортировка массива

int[] arr = {1, 5, 6, 3, 4 ,4 , 7, 1, 1, 1};

void PrintArray (int[] array)
{
    int count = array.Length;
    for(int i =0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelecionArray(int[] array)
{
    for(int i =0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i+1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition])minPosition = j; 

        }
        int temporary = array[i];
        array[i]=array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelecionArray2(int[] array)
{
    for(int i =0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for(int j = i+1; j < array.Length; j++)
        {
            if(array[j] > array[minPosition])minPosition = j; 

        }
        int temporary = array[i];
        array[i]=array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);

SelecionArray(arr);
PrintArray(arr);

SelecionArray2(arr);
PrintArray(arr);
