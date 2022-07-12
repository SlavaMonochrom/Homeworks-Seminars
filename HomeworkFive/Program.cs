int[] CreateArray(int size) //создание массива с двузначными(для первых двух задач)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);
    return newArray;
}

double[] DoubleArray(int Size)  //создание массива вещественных чисел(для третьей)
{
    double[] Doublearray = new double[Size];
    for(int i = 0; i < Size; i++)
    {
        Doublearray[i] = new Random().Next(1,9) + new Random().NextDouble(); 
    }
    return Doublearray;
}

double diffMaxMin(double[] array) // разность между макс и мин
{
    double min = array[0];
    double max = array[1];
    double dif = 0;
    for(int i = 1; i <array.Length; i++)
    {
        if (array[i] < min) array[i] = min;
        if (array[i] > max) array[i] = max;
    }
    dif = max - min; 
    return dif;
}

void ShowArray(int[] array) // для натуральных (попытки провести два аргумента int[]array и double[]array-for не даст)

{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

void Showarray(double[] array) // для вещественных
{
    for(int i = 0; i < array.Length; i++)
        Console.Write($" / {array[i]} ");
}


int evenArray(int[] array)  // четные
{
    int sumDigits = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) sumDigits++;
    return sumDigits;
}

int unevenArray(int[] array) // сумма на нечетных i
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
        if (i % 2 == 1) sum += array[i];
    return sum;
}

//Task 1 количество чётных чисел в массиве
/*
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
ShowArray(array);
Console.WriteLine();
int EvenDigits = evenArray(array);
Console.WriteLine($"even digits: {EvenDigits}");
*/

/*
// Task2 Найдите сумму элементов, стоящих на нечётных позициях.
int SumUnevenIndex = unevenArray(array);
Console.WriteLine($"Sum UnvenIndex: {SumUnevenIndex}");
*/

/*
// Task3 массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом.
Console.WriteLine("Input size massive: ");
int Size = Convert.ToInt32(Console.ReadLine());
Double[] array = DoubleArray(Size);
Showarray(array);
Console.WriteLine();
double dif = diffMaxMin(array);
Console.WriteLine($"Difference : {dif}");

*/