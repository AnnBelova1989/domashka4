int Number(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
int Result(int A, int B)
{
    int result=A;
    for (int i = 1; i < B; i++)
    {
        result= result*A;
    }
    return result;
}
int numberA=Number("Ввведите число А: ");
int numberB=Number("Ввведите число B: ");
int Vozvedenie= Result(numberA,numberB);
System.Console.WriteLine($"Число {numberA} в степени {numberB} равно {Vozvedenie}");
