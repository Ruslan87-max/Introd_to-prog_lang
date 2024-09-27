Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int j = 0;

Console.WriteLine("\nЗаполните массив числами: ");
for(int i = 0; i < arr.Length; i ++) {
    Console.Write($"arr[{i}] = ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("\nЧётнеые числа массива: ");
while(j < arr.Length) {
    if(arr[j] % 2 == 0) {
        Console.WriteLine($"arr[{j}] = {arr[j]}");
    }
    j ++;
}

