/* Напишите метод, который принимает
 на вход два числа (A и B) и возводит число A в натуральную степень B.
Math.Pow использовать нельзя*/

int Number() // Ввод числа
{
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}

int Cube(int A, int B)
{
    int cube = A;
    for (int i = 1; i <= B; i++)
    {
        cube = cube*A;
    }
    return cube;
}

Console.WriteLine("Введите число, которое нужно возвести в степень:");
int A = Number();
Console.WriteLine("В какую степень нужно возвести:");
int B = Number();

int cube = Cube(A, B);
Console.WriteLine($"{A}^{B} = {cube}");