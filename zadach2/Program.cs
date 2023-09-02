int InputNumber(string message)
{
    System.Console.WriteLine(message);
    return int.Parse(Console.ReadLine());
}
int Sum(int num)
{
  int sum=0;
    while (num>0)
    {
        sum+=num%10;
        num=num/10;
    }
   /* {
        for ( i = 0; num!=0; i++,num/=10)
        */
    return sum;
}
int number=InputNumber("Введите число: ");
int result=Sum(number);
System.Console.WriteLine($"Сумма цифр заданного числа= {result} ");