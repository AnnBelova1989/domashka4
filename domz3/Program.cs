
// Задайте массив вещественных чисел .Найдите разницу между максим и миним значением элеменов массива.
int InputNum(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(System.Console.ReadLine());
}
double[] Array(int size)
{
    return new double[size];
}

void FillArray(double[] arr)
{
    int deviation = 10;
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round((new Random().NextDouble() - 0.5) * 2 * deviation, 2);
    }
}
void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
    System.Console.WriteLine();
}

void MaxEL(double[] arr)
{
    double max = 0;
    double min = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
            max = arr[i];
        if (arr[i] < min)
            min = arr[i];
    }
    System.Console.WriteLine($"минимальное значение {min} ");
    System.Console.WriteLine($"максимальное значение {max} ");

    System.Console.WriteLine($"Разница между максимальным и минимальным значением {max - min} ");
}
int size = InputNum("Введите размер массива: ");
double[] myArray = Array(size);
FillArray(myArray);
PrintArray(myArray);
MaxEL(myArray);