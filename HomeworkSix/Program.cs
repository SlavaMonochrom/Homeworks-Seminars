int[] CreateArray(int size)
{
int[] newArray = new int(size);
    for(int i = 0; i < size; i++)
        Console.WriteLine($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    return newArray;
}

int sumPositiveCells(int[]newArray)
{
int sum = 0;
    for(int i = 0; i<newArray.Length; i++)
        if (newArray[i]>0) sum++;
    return sum; 
}

void ShowArray(int[]newArray)
{
    for(int i =0; i<newArray.Length;i++)
        Console.WriteLine($"{array[i]}  ");
        Console.WriteLine();
} 

int intersection (int x, int y)
{
Console.WriteLine("input b1 ");
int b1 = Console.ReadLine();
Console.WriteLine("input b2");
int b2 = Console.ReadLine();
Console.WriteLine("input k1");
int k1 = Console.ReadLine();
Console.WriteLine("input k2");
int k2 = Console.ReadLine();

    int x = (b2-b1)/(k1/k2);
    int y = k1*x+b1;
}

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(intersection(x,y));


//Task1 ввод с клавиатуры M чисел. Cколько чисел больше 0 ввёл пользователь.
/*
Console.WriteLine("Input size array: ");
int size = Console.ReadLine();
int[] CreateArray(size);

*/

//
