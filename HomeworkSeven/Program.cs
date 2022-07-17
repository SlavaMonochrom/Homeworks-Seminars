
double[,] CreateArray(int rows, int collums)
{
    double[,] newArray = new double[rows, collums];
    Random random = new Random();
    for (int i = 0; i < newArray.GetLength(0); i++)
            for (int j = 0; j < newArray.GetLength(1); j++)
    newArray[i, j] = Random.NextDouble();
    }
    return newArray;
}

/*
Void Show2dArray(double[,] newArray)
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
*/
//Show2dArray(array);

//Task1 двумерный массив размером m×n, заполненный случайными вещественными числами





double[,] array = new double[5, 10];

Random random = new Random();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 10; j++)
    {
        array[i, j] = random.NextDouble()*100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write($"{array[i, j]}");
    }
    Console.WriteLine();
}