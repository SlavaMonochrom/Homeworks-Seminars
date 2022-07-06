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

Console.WriteLine("Input elements digit : ");
int digit = Convert.ToInt32(Console.ReadLine());
int[] intArrayVarriable = new int[digit];


void PrintArray(int[]array)   //??? это внос в индекс или в весь массив? 
{   
    int count = 0;
    int m = array.Length;
    while(m<=count)
    {
        int  = new Random().Next(1,10); // как обозначить нулевой индекс массива без указания оного ? 
        count++;
    }
    Console.WriteLine(array); // как правильно вывести в консоль? 
}
PrintArray(int []digit); // Как правильно обратиться к методу? 

