int factorial(int n)
    {
        int i, x = 1;
        for (i = 1; i <= n; i++)
        {
            x *= i;
        }
        return x;
    }

Console.Write("Введите коэффициент = ");
int n = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= n; i++)
{
    for (int c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, чем ниже строка, тем меньше отступ
    {
        Console.Write(" "); 
    }
    for (int c = 0; c <= i; c++)
    {
        Console.Write(" "); // создаём пробелы между элементами треугольника
        Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
    }
    Console.WriteLine(); // после каждой строки с числами отступаем строку
}