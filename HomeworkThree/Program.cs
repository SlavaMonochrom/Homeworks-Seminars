//принимает на вход пятизначное число и проверяет на палиндром. 

/*void Palindrome(int num)

{   
    if (num / 10000 == num % 10 && num / 1000 % 10 == (num % 100) / 10) Console.WriteLine("This is a Palinrome");
    else 
    Console.WriteLine("This is are not a Palindrome");
    
}
Console.WriteLine("Inpet are number: ");
int number = Convert.ToInt32(Console.ReadLine());
Palindrome(number); */

//принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Qube(int num)
{
    int result;
    
    for (int current = 1; current <= num; current++)
    {
        result = current * current * current;
        Console.Write(result + " ");
    }
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
Qube(number);
