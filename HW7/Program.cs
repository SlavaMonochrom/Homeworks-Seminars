
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

int[,] CreateRandonArray(int rows, int collums, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, collums];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < collums; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    return newArray;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) // 0 - строка
    {
        for (int j = 0; j < array.GetLength(1); j++)  // .GetLenth(1) - столбец для многомерных массивов 
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

void FindElement(int[,] myArray)
{

    int m = 0;
    int n = 0;
    for (int i = 0; i < myArray.GetLength(0); i++)

        for (int j = 0; j < myArray.GetLength(1); j++)

            if (m < myArray.GetLength(0) && n < myArray.GetLength(1))
                myArray[i,j] = myArray[m,n];
                Console.WriteLine ($"Элемент равен: {myArray[m,n]}");
            else 
            {
                Console.WriteLine($"такого элемента не сущетсвует");
            }

}

//Task1 
Console.WriteLine("Input m: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input n: ");
int collums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
//double[,] array = CreateArray(rows, collums);
//Show2dArray(array);



//Task2 на вход позиции элемента в array. возвращает значение элемента или "элемента нет"

int[,] myArray = CreateRandonArray(rows, collums, min, max);
ShowArray(myArray);

Console.WriteLine("Input position in rows: ");
int  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input position in columns: ");
int  = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Input Rows: ");

