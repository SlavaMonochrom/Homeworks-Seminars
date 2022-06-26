// на вход принимает число (N), на выходе чётные числа от 1 до N.

int n; //even;
int current;
current = 0;


Console.WriteLine("Введите значение N:  ");
n = Convert.ToInt32(Console.ReadLine());


while(current>=1)
{

    Console.Write(current + " ");
    current++;
}
//(num%2 ==0)