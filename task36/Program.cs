// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.Write("Количество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] arr = new int[size];
RandomNumbersArray(arr);
PrintArray(arr);
int sum = 0;

for (int i = 0; i < arr.Length; i+=2)
    sum = sum + arr[i];

    Console.Write($"Сумма элементов на нечётных позициях: {sum}");

void RandomNumbersArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
        {
            arr[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int k = 0; k < arr.Length; k++)
      if (k != arr.Length-1)
        {
            Console.Write($"{arr[k]} ");
        }
        else
        {
            Console.Write($"{arr[k]}");
        }    
    Console.Write("]");
    Console.WriteLine();
}