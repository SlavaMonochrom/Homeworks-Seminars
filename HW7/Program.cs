
double[,] CreateArray(int rows, int collums)
{
    double[,] newArray = new double[rows, collums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < collums; j++)
            newArray[i, j] = new Random().NextDouble() * 10;
    return newArray;
}

void Show2dArray(double[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
            Console.Write(newArray[i, j] + " ");

        Console.WriteLine();
    }
}


Console.WriteLine("Input m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n: ");
int collums = Convert.ToInt32(Console.ReadLine());
double[,] array = CreateArray(rows, collums);
Show2dArray(array);
