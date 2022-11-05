int [,] initArr (int row, int col) // инициализация двумерного массива 
{
    int [,] array = new int [row, col];

    Random rand = new Random();

    for (int i = 0 ; i < row ; i++)
    {
        for (int j = 0 ; j < col ; j++)
        {
            array[i,j] = rand.Next(10, 99);
        }
    }
    return array;
}

void printArr(int[,] array, int row, int col) // вывод в консоль массива
{
    for (int i = 0 ; i < row ; i++)
    {
        for (int j = 0 ; j < col ; j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите колличество строк в матрице = ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов в матрице = ");
int col = Convert.ToInt32(Console.ReadLine());

int [,] arr = initArr (row,col);
printArr(arr, row, col);

int min = 100;
int minCol=0, minRow=0;
for (int i = 0; i < row; i++) // поиск строки и колонны с минимальным значением
{
    for (int j = 0; j < col; j++)
    {
        if (min > arr[i,j]) 
        {
            min = arr [i,j];
            minRow = i;
            minCol = j; 
        }
    }
}

Console.WriteLine($"minDig = {min} minRow = {minRow} minCol = {minCol} ");

int [,] arr2 = new int [row-1, col]; 

for (int i = 0; i < row-1; i++) 
{
    for (int j = 0; j < col; j++)
    {
        if (i >= minRow) arr2[i,j] = arr[i+1,j];
        else arr2[i,j] = arr[i,j];
    }
}

printArr(arr2, row-1, col);

int [,] arr3 = new int [row-1, col-1]; 
for (int i = 0; i < row-1; i++) 
{
    for (int j = 0; j < col-1; j++)
    {
        if (j >= minCol) arr3[i,j] = arr2[i,j+1];
        else arr3[i,j] = arr2[i,j];
    }
}


printArr(arr3, row-1, col-1);