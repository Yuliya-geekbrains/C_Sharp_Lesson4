// Напишите программу, которая выводит массив из восьми элементов, заполненный нулями и единицами в случайном порядке
// [1,0,1,1,0,1,0,0]

int[] getArray(int size)
{
    int[] result = new int[size]; // целочисленный массив result с размером size
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 2);
    }
    return result;
}

int[]array = getArray(8);
Console.WriteLine($"[{String.Join(",",array)}]");