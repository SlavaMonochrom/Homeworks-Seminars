
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

//Task1 ввод с клавиатуры M чисел. Cколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Input size array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] CreateArray(size);
