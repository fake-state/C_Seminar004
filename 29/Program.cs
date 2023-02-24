// Напишите метод, который 
// задаёт массив из N элементов и выводит их на экран.

void Array(int[] x)
{
    int index = 0;
    int length = x.Length;
    while(index < length)
    {
        x[index] = new Random().Next(1, 100);
        index ++;
    }
}

void Print(int[] x)
{
    int index = 0;
    int length = x.Length;
    Console.Write("[ ");
    while(index < length)
    {
        Console.Write($"{x[index]} ");
        index++;
    }
    Console.Write("]");
}

Console.WriteLine("Сколько элементов будет в массиве?: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

Array(arr);
Console.WriteLine("Ваш массив: ");
Print(arr);