// Напишите метод, который 
// задаёт массив из N элементов и выводит их на экран.

void Array(int[] x, int n)
{
    int index = 0;
    while(index < n)
    {
        x[index] = new Random().Next(1, 100);
        index ++;
    }
}

void Print(int[] x, int n)
{
    int index = 0;
    Console.Write("[ ");
    while(index < n)
    {
        Console.Write($"{x[index]} ");
        index++;
    }
    Console.Write("]");
}

Console.WriteLine("Сколько элементов будет в массиве?: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

Array(arr, n);
Console.WriteLine("Ваш массив: ");
Print(arr, n);