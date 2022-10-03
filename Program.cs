// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();

int count = 5;
int[] array = new int[count];
int max = 0;
int min = 0;

AddArray(array);
PrintArray(array);

void AddArray(int[] array)
{
    Random rand = new Random();
    for(int i = 0; i < count; i++)
    {
        array[i] = rand.Next(-9,9);
        
        if(max < array[i])
        max = array[i];

        if(min > array[i])
        min = array[i];
    }
}

void PrintArray(int[] array)
{
    Console.Write("[");

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");

        if(i == count - 1)

            Console.WriteLine($"], разница между наибольшим и наименьшим числом - {max - min}");

        else Console.Write(", ");
    }
    Console.WriteLine();
    }
