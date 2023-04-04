// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16


int ReadInt(string argument)
{
    System.Console.WriteLine($"Input {argument}");
    return int.Parse(Console.ReadLine());
}

int number = ReadInt($"Введите число которое будем возводить в степень: ");
int degree = ReadInt($"Введите степень в которую будем возводить число: ");

void Task1(int number, int degree)
{
int result = number; // будет равна число которую надо возвести в степень
for (int i = 2; i <= degree; i++) // повторяем до до кого пока она не будет равно числу степени
{
    result = result * number;
}
System.Console.WriteLine($"Число {number} в степени {degree} будет равна {result}");
}

Task1(number, degree);