// Напишите программу, которая на вход принимает трёхзначное число и на выходе показывает последнюю цифру этого числа.
Console.Write("Введите цифру от 100 до 999: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 100 || num > 999)
    {
    Console.Write("Число не трёхзначное");
    }
else
    {
    Console.WriteLine(num % 10);
    }