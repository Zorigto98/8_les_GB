int [,,] initArr (int mat, int row, int col ) // инициализация двумерного массива 
{
    int [,,] array = new int [mat, row, col];
    Random rand = new Random();
    for (int k = 0; k < mat; k++)
    {
        for (int i = 0 ; i < row ; i++)
        {
            for (int j = 0 ; j < col ; j++)
            {
                array[k,i,j] = rand.Next(10, 99);
            }
        }
    }
    
    return array;
}

void printArr(int[,,] array, int mat, int row, int col) // вывод в консоль массива
{
    for (int k = 0; k < mat; k++)
    {
        for (int i = 0 ; i < row ; i++)
        {
            for (int j = 0 ; j < col ; j++)
            {
                Console.Write($"{k}{i}{j} |{array[k,i,j]}| ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    
}
Console.Write("Введите колличество матриц = ");
int mat = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество строк в матрице = ");
int row = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов в матрице = ");
int col = Convert.ToInt32(Console.ReadLine());

int [,,] arr = initArr (mat, row, col);
printArr(arr, mat, row, col);