// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("_Задача 1_");

Console.WriteLine("Введите 2 целых числа: ");

string aString = Console.ReadLine();
string bString = Console.ReadLine();

int a = Convert.ToInt32(aString); // переводим тип string в int
int b = Convert.ToInt32(bString);

Console.WriteLine("_Ответ на Задачу 1_");

if (a>b) Console.WriteLine("a>b");
else if (a<b) Console.WriteLine("a<b");
else  Console.WriteLine("a равно b");






//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

// Console.WriteLine("_Задача 2_");

// // Console.WriteLine("Введите 3 целых числа: ");

// string aString = Console.ReadLine();
// string bString = Console.ReadLine();
// string сString = Console.ReadLine();

// int a = Convert.ToInt32(aString); // переводим тип string в int
// int b = Convert.ToInt32(bString);
// int d = Convert.ToInt32(сString);

// int max = a;

// if (b > max) 
// {
//     max = b;
// };
// if (d > max) 
// {
//     max = d;
// };

// Console.WriteLine("_Ответ на Задачу 1_");
// Console.Write("max = ");
// Console.WriteLine(max);

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

//  Console.WriteLine("_Задача 3_");

// Console.WriteLine("Введите 1 целое число: ");

// string aString = Console.ReadLine();
// int a = Convert.ToInt32(aString); // переводим тип string в int

// if ((a%2 == 0))  Console.WriteLine("Число четное");
// else Console.WriteLine("Число не четное");

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.WriteLine("_Задача 4_");

// Console.WriteLine("Введите целое число N: ");

// string nString = Console.ReadLine();
// int n = Convert.ToInt32(nString); // переводим тип string в int

// int i = 1;

// Console.WriteLine("_Ответ на Задачу 4_");

// while(i < (n+1))
// {
//     if (i%2 == 0) Console.WriteLine(i);
//     i++;
// }

