// Напишите код проверяющий является ли заданное число четным

Console.Write ("Введите число ");
string number = Console.ReadLine()!;
int num = int.Parse(number);
if (num % 2 == 0)
{
Console.WriteLine("Число является четным");
}
else
{
Console.WriteLine("Число не является четным");
}