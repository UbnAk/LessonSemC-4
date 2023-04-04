//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


int [] array = new int[8];
for (int i = 0; i <= array.Length-1; i++)
{
    array[i] = new Random().Next(0,10); 
}
System.Console.Write("[");
Console.Write(string.Join(", ", array));
System.Console.Write("]");