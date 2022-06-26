// на вход принимает число (N), на выходе чётные числа от 1 до N.

int n,current;
current= 1;

Console.WriteLine("Введите число N:  ");
n = Convert.ToInt32(Console.ReadLine());

if(n<=1)
{
    Console.WriteLine("Это число не подходит, начните с единицы. ");
}
while(current<=n)
{   
    if (current%2 == 0)
   {
        Console.Write(current + " ");
        current++;
    }
    current++;
}