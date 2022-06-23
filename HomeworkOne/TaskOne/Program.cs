//на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

int num1;
int num2;

Console.WriteLine("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("max = " + num1);
    Console.WriteLine("max = " + num2);
}
else if (num1 == num2)
{
        Console.WriteLine("числа равны");
}
