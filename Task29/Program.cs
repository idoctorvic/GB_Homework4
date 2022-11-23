// Напишите программу, которая задаёт массив из 8 элементов и 
// выводит их на экран.

int[] array = new int[8];

int[] FillArray(int[] arr)
{
    var result = new int[arr.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        result[i] = new Random().Next(1, 100);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

var newArray = FillArray(array);
PrintArray(newArray);

// int[] arr = {1, 2, 5, 7, 19, 6, 1, 33};

// void PrintArray(int[] array)
// {
// 	int count = array.Length;
// 	for(int i = 0; i < count; i++)
// 	{
// 		Console.Write($"{array[i]} ");
// 	}
// 	Console.WriteLine();
// }
// PrintArray(arr);