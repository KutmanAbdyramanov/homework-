// Напишите программу которая показывает меньшее и большее числа

Console.Write ("Введите первое число ");
string number = Console.ReadLine()!;
int num = int.Parse(number);

Console.Write ("Введите второе число ");
number = Console.ReadLine()!;
int num2 = int.Parse(number);
if (num > num2)
        {
            Console.WriteLine($"{num} = Max, {num2} = Min");
        }
        else if (num2 > num)
        {
            Console.WriteLine( $"{num2} = Max, {num} = Min");
        }
        else
        {
            Console.WriteLine("Числа равны");
        }

        Console.ReadLine();