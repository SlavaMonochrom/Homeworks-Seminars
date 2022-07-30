/*54 упорядочит по убыванию элементы каждой строки двумерного массива.*/

double[,] Create2DArray(int rows, int columns)

{
    double[,] array = new double[rows,columns];
    for (int i = 0; i<rows; i++)
        for(int j = 0; j <columns; j++)
        array[i,j] = new Random().Next(1,10);
    return array;
}

void Prind2DArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    { 
        for(int j = 0; j< array.GetLength(1);j++)
            Console.Write(array[i,j]+ " ");
    Console.WriteLine();    
    }
}

double[,] SortMinMaxRows(double[,] array)
{
    double temp;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j<array.GetLength(1)-1;j++)
        {
            for(int n = j+1; n<array.GetLength(1);n++)
            {
                if(array[i,j]>array[i,n])
                {
                temp = array[i,j];   
                array[i,j] = array[i,n];
                array[i,n] = temp;
                }
            }
        }
    }    
    return array;
}


Console.Write("Input rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] myArray = Create2DArray(rows,columns);
Prind2DArray(myArray);
Console.WriteLine();


Prind2DArray(SortMinMaxRows(myArray));