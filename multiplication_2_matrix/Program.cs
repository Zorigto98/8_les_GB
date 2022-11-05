int [,] initArr (int row, int col) // инициализация двумерного массива 
{
    int [,] array = new int [row, col];

    Random rand = new Random();

    for (int i = 0 ; i < row ; i++)
    {
        for (int j = 0 ; j < col ; j++)
        {
            array[i,j] = rand.Next(1, 10);
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

Console.Write("Введите колличество строк в матрице 1 = ");
int row1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов в матрице 1 = ");
int col1 = Convert.ToInt32(Console.ReadLine());

int [,] arr1 = initArr (row1,col1);

Console.Write("Введите колличество строк в матрице 2 = ");
int row2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов в матрице 2 = ");
int col2 = Convert.ToInt32(Console.ReadLine());

int [,] arr2 = initArr (row2,col2);

Console.WriteLine("Матрица 1: ");
printArr(arr1, row1, col1);
Console.WriteLine("Матрица 2: ");
printArr(arr2, row2, col2);

if (col1 == row2) 
{
    int [,] arr3 = new int [row1, col2]; 
    Random rand = new Random();
    for (int i = 0; i < row1; i++)
    {
        for (int j = 0; j < col2; j++)
        {
             for (int k = 0; k < col1; k++)
             {
                arr3[i,j] += arr1[i,k] * arr2[k,j];
             }
        }
    }
    Console.WriteLine("Матрица 3: ");
    printArr(arr3, row1, col2);
} else Console.WriteLine("Такие матрицы нельзя умножить друг на друга");

