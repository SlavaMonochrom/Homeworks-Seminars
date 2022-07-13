
int Summa(int num)
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

int[] CreateArray(int size) 
{ 
    int[] newArray = new int[size];
    for(int i = 0; i < size; i++) 
        newArray[i] = new Random().Next(5, 25);
    return newArray; 
} 

void ShowArray(int[] array) 
{ 
    for(int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " "); 
 
    Console.WriteLine(); 
} 
 
//Task1 на вход число и выдаёт сумму цифр в числе
/*
Console.WriteLine("inpunt number ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Summa(number));
*/

//Task2 задаёт массив из m элементов и выводит их на экран.
/*
Console.Write("Input size of array: "); 
int  size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
ShowArray(array);
*/