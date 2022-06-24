//принимает на вход три числа и выдаёт максимальное из этих чисел
int num1,num2,num3,max;

Console.WriteLine("Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());

if(num1 >= num2)
{
    max = num1;
}
else
{
    max = num2;
}

if(num3 > max)
{
    max = num3;
}
Console.WriteLine("Максимум ранво " +  max);

