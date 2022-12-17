//Напишите программу, которая на вход принимает одно число (N), а на выходе показывет все целые числа от -N до N.
Console.WriteLine("Введите цифру: ");
int num = Convert.ToInt32(Console.ReadLine());
int i = 0;
int numMax = 0;
if (num < 0)
{
    i = num;
    numMax = num * -1;
}
else
{
    i = num * -1;
    numMax = num;
}
while (i < numMax + 1)
{
    Console.Write(i);
    Console.Write(" ");
    i++;
}