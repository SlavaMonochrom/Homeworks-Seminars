//Задайте значение N, найдет кол-во цифр в числе N.
int sumOfDigits(int n)
{
    if (n > 9)
    {
        return 1 + sumOfDigits(n =n/10);
    }
    else return n;
}

int sumDigit(int n, int m)
{
    if(n>m)
    {
        return n + sumDigit(m, n - 1);

    }
    else return n;
}

//Task1
/*
Console.WriteLine("Input N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sumOfDigits(N));
*/

//Task2 сумму элементов от M до N

Console.WriteLine("Input x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input y");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine(sumDigit(x,y));
