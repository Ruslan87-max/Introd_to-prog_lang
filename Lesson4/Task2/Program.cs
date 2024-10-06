int[,] CreateArrAy(int rowCount, int columnCount)
{
    Random random = new Random();
    int[,] table = new int[rowCount, rowCount];

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = random.Next(1, 1000);
        }
    }
    return table;
}

void ShowMatrix(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i,j]} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateArrAy(3, 3);
ShowMatrix(matrix);
Console.WriteLine();

foreach (int e in matrix)
{
    if (IsInteresting(e) == true)
    {
        Console.Write($"{e} ");
    }

}

bool IsInteresting(int value)
{
    bool x;
    int sumOfDigits = GetsumOfDigits(value);
    return x = sumOfDigits % 2 == 0 ? true : false;
}

int GetsumOfDigits(int value)
{
    int sumOfDigits = 0;
    while (value > 0)
    {
        sumOfDigits += value % 10;
        value /= 10;        
    }
    return sumOfDigits;
}

