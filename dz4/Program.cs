/*Напишите программу, которая на вход принимает число (N),
 а на выходе показывает все чётные числа от 1 до N.*/

 Console.Write ("Введите число ");
string number = Console.ReadLine( )!;
int num = Convert.ToInt32(number);
int start = 0;
while (start <= num)
{
    if (num % 2 == 0)
{
Console.Write(start+" , ");
start += 2;

}
}
