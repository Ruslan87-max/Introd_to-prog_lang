using System.Linq;
using System;

int[,] CreateMatrix(int rowCount, int columnCount)
{
    Random random = new Random();
    int[,] table = new int[rowCount, rowCount];

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = random.Next(1, 11);
        }
    }
    return table;
}

void ShowMatrix(int[,] table)
{
    string s = "";
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            s = s.Insert(j, Convert.ToString(table[i, j]));
        }
        Console.Write(String.Join(", ", s.AsEnumerable()));
        Console.WriteLine();
        s = "";
    }
}

ShowMatrix(CreateMatrix(5, 5));

