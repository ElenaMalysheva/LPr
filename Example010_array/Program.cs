int[] array = {1,12,13,14,51,25,24,23,54,53,44};

int n = array.Length; //количество элементов в массиве
int find = 51;
int index = 0;

while(index<n){
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //прерываем цикл
    }
    index++;
}

