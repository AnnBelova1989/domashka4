int InputNumber(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
int[] ArrayofNumbers(int size)
{
    int[]array= new int [size];
    for (int i = 0; i < size; i++)
    {
        array[i]=new Random().Next();
    }
    return array;
}
void PrintArray(int[]array)
{
    for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"{array[i]}, ");
}
}
    int size=InputNumber("Введите число элементов: ");
    int[]result= ArrayofNumbers(size);
    PrintArray (result);
