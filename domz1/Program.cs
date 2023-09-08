// Задайте массив, заполненнный случайными положительными трехзначными числами. Напишипте программу, к-я покажет кол-во четных чисел в массиве

int Input(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int[] CreateArray(int size)
{
    return new int[size];
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        arr[i] = new Random().Next(100, 1000);
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}
int Chetn(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i ++)
    {
        if(arr[i]%2==0)
        count++;
    }
    return count;
}

int size = Input("Введите размер массива: ");
int[] myArray = CreateArray(size);
FillArray(myArray);
PrintArray(myArray);
int chetn = Chetn(myArray);
System.Console.WriteLine($"Количество четных чисел в массиве {chetn}");
