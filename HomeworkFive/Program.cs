int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(100, 1000);
    return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
}
int evenArray (int[]array)
{
    int sumDigits = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) sumDigits++;
    return sumDigits;
}    

int unevenArray(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
        if (i % 2 == 1) sum +=array[i];
    return sum;
}


//Task 1 количество чётных чисел в массиве
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
ShowArray(array);
Console.WriteLine();
int EvenDigits = evenArray(array);
Console.WriteLine($"even digits: {EvenDigits}");

// Task2 Найдите сумму элементов, стоящих на нечётных позициях.
int SumUnevenIndex = unevenArray(array);
Console.WriteLine($"Sum UnvenIndex: {SumUnevenIndex}");






