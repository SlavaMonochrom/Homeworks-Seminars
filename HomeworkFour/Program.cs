//на вход число и выдаёт сумму цифр в числе

/*int Summa(int num)
{
    int sum = 0;

    if (num < 0) Console.WriteLine(num = -1);
    else
    {
        while (num > 0)
        {
            sum = sum + num % 10;
            num = num / 10;
        }
        
    }
    return sum;
}

Console.WriteLine("inpunt number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Summa(number));
*/


//задаёт массив из m элементов и выводит их на экран.

int[] array = new Random().Next(1, 10);

Console.WriteLine(array);
