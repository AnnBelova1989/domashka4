//Задать одномерный массив , заполненный случайными числами. Найдите сумму элементов, состоящих на нечетных позициях.

int Input(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}

int[] Array(int size)
{
    return new int[size];
}

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-10, 10);
    }
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}
void SumElem(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    System.Console.WriteLine($"Сумма чисел на нечетных позициях равна {sum}");
}

int size = Input("Введите размер массива: ");
int[] array = Array(size);
FillArray(array);
PrintArray(array);
SumElem(array);
