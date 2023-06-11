// Написать код который выдаст большее число из заданных трех

Console.Write ("Введите первое число ");
string number = Console.ReadLine()!;
int num = int.Parse(number);

Console.Write ("Введите второе число ");
number = Console.ReadLine()!;
int num2 = int.Parse(number);

Console.Write ("Введите третье число ");
number = Console.ReadLine()!;
int num3 = int.Parse(number);
if (num > num2 && num > num3)
{
Console.WriteLine("Наибольшее число: " + num);
}
else if (num2 > num && num2 > num3)
{
Console.WriteLine("Наибольшее число: " + num2);
}
else if (num3 > num && num3 > num2)
{
Console.WriteLine("Наибольшее число: " + num3);
}
else
{
Console.WriteLine("Числа равны");
}





