// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

int N = ReadInt();

int ReadInt()
{
    System.Console.WriteLine("Введите число: ");
    return int.Parse(Console.ReadLine());
}

void Task1()
{
int a = 0;
while (N>0)
{
    int b = N%10;
    N = N / 10;
    a = a + b;
}
System.Console.WriteLine(a);
}
Task1();