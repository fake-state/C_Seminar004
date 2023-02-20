/*Напишите метод, который принимает 
на вход число и выдаёт сумму цифр в числе.*/

int Number()
{
    Console.WriteLine("Введи число и я покажу сумму его цифр:");
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}

int Sum(int n)
{
    int sum = 0;
    int temporary = n;
    while(n > 10)
    {
       temporary = n % 10;
       sum = sum + temporary;
       n = n / 10;
    }
    sum = sum + n;
    return sum;
}

int N = Number();

Console.WriteLine(Sum(N));