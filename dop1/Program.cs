// дан массив: наполнени числами от 1 до N
// Задача:выяснить сколько раз какое число встречается

int NumberFillArray(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray(int[] x, int N)
{
    int index = 0;
    int length = x.Length;
    for (index = 0; index < length; index++)
    {
        x[index] = new Random().Next(1, N);
    }
}

void PrintArray(int[] x)
{
    int index = 0;
    int length = x.Length;
    Console.WriteLine("Ваш массив: ");
    for ( index = 0; index < length; index++)
    {
        Console.Write($"{x[index]} ");
    }
}
int N = NumberFillArray("Введите число");
int[] Array = new int[N];
FillArray(Array, N);
PrintArray(Array);

