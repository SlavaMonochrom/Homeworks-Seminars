
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

            Console.WriteLine();
    }
}

int[,] ArrayRandom(int rows, int collums)
{
    int[,] array = new int[rows, collums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < collums; j++)
            array[i, j] = new Random().Next(5, 25);
    return array;
}

void ShowArray(int[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)

            Console.WriteLine();
    }
}

int[,] FindElement (int[,]myArray)
{
int count = 0;
int position1 = 0;
int p2 = 0;
Console.WriteLine("Input position in rows: ");
position1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input position in columns: ");
p2 = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <myArray.GetLength(0) i++)
    if (myArray[i] == position1)
        Console.WriteLine();
        for (int j = 0; j < myArray.GetLength(1); j++)
            if(myArray[j] == p2);

}
//Task1 
Console.WriteLine("Input m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n: ");
int collums = Convert.ToInt32(Console.ReadLine());
//double[,] array = CreateArray(rows, collums);
//Show2dArray(array);

//Task2 на вход позиции элемента в array. возвращает значение элемента или "элемента нет"

int[,] myArray = ArrayRandom(rows, collums);
ShowArray(myArray);
Console.WriteLine("Input Rows: ");

