// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Количество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] arr = new int[size];
RandomNumbersArray(arr);
PrintArray(arr);
int count = 0;

for (int i = 0; i < arr.Length; i++)
if (arr[i] % 2 == 0)
count++;

Console.Write($"{count} чётных числа");

void RandomNumbersArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int k = 0; k < arr.Length; k++)
    {
        // Console.Write($"{arr[i]} ");
        if (k != arr.Length-1)
        {
            Console.Write($"{arr[k]} ");
        }
        else
        {
            Console.Write($"{arr[k]}");
        }    
    }
    Console.Write("]");
    Console.WriteLine();
}