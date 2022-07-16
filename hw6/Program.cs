
int[] CreateArray(int size)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Input {i + 1} element: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"{newArray[i]} ");
         
    }
    Console.WriteLine();   
}

void sumPositiveCells(int[]array)
{
int sum = 0;
       for(int i = 0; i<array.Length; i++)
        if (array[i] > 0) sum++;
Console.WriteLine($"Sum positive:{sum}");
}

int intersection(int k1, int k2, int b1, int b2)
{
    int x = (b2 - b1) / (k1 - k2);
    return x;
}

//Task1 
Console.Write("iputs elements array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arrayOne = CreateArray(size);
ShowArray(arrayOne);
sumPositiveCells(arrayOne);

//int sum = sumPositiveCells(arrayOne);
//Console.WriteLine(sum);

//Task2
/*
Console.WriteLine("input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());
if (k1 == k2) Console.WriteLine("Паралельны");
else
    Console.WriteLine("input b1");
    int b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("input b2");
    int b2 = Convert.ToInt32(Console.ReadLine());
int x = intersection(k1, k2, b1, b2);
int y = k1 * x + b1;
Console.WriteLine($" точка пересечения: {x}, {y}");
*/