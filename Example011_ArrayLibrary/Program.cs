void FillArray (int[]collection) //Метод, чтобы присвоить в массиве рандомные значенния
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintArray(int[]col) // Метод для вывода значений массива
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position]);
        position++;
    }
}
int IndexOf(int[]collection, int find) // Метод для поиска нужного значения
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index < count)
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
int[] array = new int[10]; // Определяем в массиве определенное колличество элементов
FillArray(array);
array[4] = 4;
array[7] = 4;
PrintArray(array);
Console.WriteLine();
int pos = IndexOf(array,4);
Console.WriteLine(pos);