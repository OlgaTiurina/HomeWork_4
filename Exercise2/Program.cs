// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (n > 0)
{
    int n1 = n % 10;
    n = n / 10;
    sum = sum + n1;
}

Console.WriteLine("Сумма цифр в числе равна: " +sum);

