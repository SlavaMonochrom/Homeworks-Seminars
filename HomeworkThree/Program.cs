//принимает на вход пятизначное число и проверяет на палиндром. 

/*int Palindrome(int num)
{   
    if (num<=0) Console.WriteLine( num = -1);
    if (num / 10000 == num % 10 && num / 1000 % 10 == (num % 100) / 10) Console.WriteLine("This is a Palinrome");
    else 
    {
        Console.WriteLine("This is are not a Palindrome");
    }
    return num;
}

Console.WriteLine("Inpet are number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Palindrome(number));
*/


//принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


void Qub(int num)
{
    for (int current = 2; current <= num; current++)
    {
        num =  *  * ;
        Console.Write(" " + num);
    }
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Qub(number);