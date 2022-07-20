// // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// // 456 -> 5
// // 782 -> 8
// // 918 -> 1

// // void PrintNumber()

// int[] FillArray(int number) // создаем массив из трехзначного числа
// {
//     int lengh = 3;
//     int i = 0;
//     int[] collection = new int[3];// создаем пустой массив
//     int stepen = 2;
//     while(i < lengh)
//     {
//         int dop =  (number/Convert.ToInt32(Math.Pow(10, (stepen +1)))) * Convert.ToInt32(Math.Pow(10, (stepen +1)));
//         collection[i] = (number - dop)/Convert.ToInt32(Math.Pow(10, stepen))   ;
//         stepen = stepen - 1;
//         i++;
//     }
// return collection;
// }

// void GetNumber(int[] coll, int n)
// {
//     int index = 0;
//     int len = coll.Length;

//     while(index < len) // перебираем массив
//     {
//         if (index == n) // ишем число с нужным индексом
//         {
//             Console.Write("Ваше число: ");
//             Console.WriteLine(coll[index]);
//             break;
//         }
//         index++;
//     }
// }

// // int x = 5;
// // int stepen = 4;
// // Console.WriteLine("5^4 = " + Math.Pow(x, stepen));


// Console.WriteLine("Введите трехзначное целое число: ");

// string aString = Console.ReadLine();
// int a = Convert.ToInt32(aString); // переводим тип string в int
// int[] array = new int[3]; // создаем пустой массив

// array = FillArray(a);
// GetNumber(array, 1);

//----------------------------------------------------------------------------------------
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// void GetResult(string goal) // создаем массив из трехзначного числа
// {
//     int lengh = goal.Length;
//     if (lengh < 3)
//     {
//         Console.Write("третьей цифры нет"); // проверяем присутствие 3й цифры
//     }
//     else
//     {
//         int g = Convert.ToInt32(goal); // переводим тип string в int
//         int i = 0;
//         int stepen = lengh - 1;
//         while (i < lengh) // если в числе более 2х чисел, ищем 3ее число
//         {
//             if (i == 2) // находим третье по счету число
//             {
//                 int dop = (g / Convert.ToInt32(Math.Pow(10, (stepen + 1)))) * Convert.ToInt32(Math.Pow(10, (stepen + 1)));
//                 int result = (g - dop) / Convert.ToInt32(Math.Pow(10, stepen)); // выделяем третье число
//                 Console.Write("Ваше число: ");
//                 Console.WriteLine(result); // печатаем результат
//                 break;
//             }
//             stepen = stepen - 1;
//             i++;
//         }
//     }
// }

// Console.WriteLine("Введите целое число: ");

// string aString = Console.ReadLine();
// GetResult(aString);

//----------------------------------------------------------------------------------------
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool DayOfWeek(int n)
{
    bool weekendOrNot = true;
    if (n > 1 & n < 6) { weekendOrNot = false;}

    return weekendOrNot;
}

Console.WriteLine("Введите цифру, обозначающую день недели: ");

string aString = Console.ReadLine();
int a = Convert.ToInt32(aString); // переводим тип string в int

if (DayOfWeek(a))
{
    Console.WriteLine("Ура! Выходные");
}
else  Console.WriteLine("Работаем..");

