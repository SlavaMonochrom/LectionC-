void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while(index<lenght)
    {
        collection[index] = new Random().Next(1,10);
         index++;
    }
} 
void Printarray(int[]col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOFf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        } 
        index++;

    }
    return position;
}

int[] array = new int[10];
FillArray(array);
Printarray(array);
Console.WriteLine();

int pos = IndexOFf(array,5);
Console.WriteLine(pos); 