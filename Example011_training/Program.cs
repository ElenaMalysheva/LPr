void FillArray(int[] collection)
{
    int lengh = collection.Length;
    int i = 0;
    while(i < lengh)
    {
        collection[i] = new Random().Next(1,10);
        i++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
} 

int[] array = new int[10]; //создаем массив из 10 элементов по умолчанию заполнен "0"

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //определяем как -1 == элемент не найден
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
return position;
}


FillArray(array);

array[4] = 4;

PrintArray(array); 



Console.WriteLine();
int pos = IndexOf(array, 44);
Console.WriteLine(pos);
