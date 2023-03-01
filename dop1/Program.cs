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
    Console.WriteLine("Ваш массив: ");

    for ( int index = 0; index < x.Length; index++)
    {
        Console.Write($"{x[index]} ");
    }
    Console.WriteLine(" ");
    Console.WriteLine(" ");
}

void Count(int[] array)
{
    int indexOutside = 0;
    int number = 0;
    int count = 0;
    int indexInside = 0;
    for (indexOutside = 0; indexOutside < array.Length; indexOutside++)
    {
        number = array[indexOutside];
        for (indexInside = 0; indexInside < array.Length; indexInside++)
        {
            if (array[indexInside] == number)
                count++;
        }
    
        Console.WriteLine(number + " repit " + count + " times");
        array = array.Distinct().ToArray();
        
        indexInside = 0;
        count = 0;
    }
}
// void Count(int[] x, int N)
// {
//     int[] count = new int[N];
//     foreach (int number in x)
//     {
//         count[number - 1]++;
//     }
//     Console.WriteLine(string.Join(" ", x));
//     Console.WriteLine(string.Join(" ", count));
    
// }

int N = NumberFillArray("Введите число");
int[] Array = new int[N];
FillArray(Array, N);
PrintArray(Array);
Count(Array);

