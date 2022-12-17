//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();

    int number = 8;    

int[] FillArray(int[] array)
{
    int lenght = array.Length;
    
        for (int i = 0; i < lenght; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int index;

    for (index = 0; index < count; index++)
    {
        Console.WriteLine(col[index] + " ");
    }
}
int[] array = new int[number];
array = FillArray(array);
PrintArray(array);