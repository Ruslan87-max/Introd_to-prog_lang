void ZeroEvenElemenets(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (int e in arr)
    {
        Console.Write($"{e} ");
    }
}

// int[] array = {1,3,7,9 };
// int[] array = {2,5,7,4,8,9,22};
int[] array = {};
ZeroEvenElemenets(array);
PrintArray(array);