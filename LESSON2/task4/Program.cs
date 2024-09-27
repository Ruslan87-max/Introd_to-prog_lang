Console.Write("Введите количество гирь: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int max = arr[0];
int j = 0;

Console.WriteLine("\nЗаполните массив числами: ");
for(int i = 0; i < arr.Length; i ++) {
    Console.Write($"arr[{i}] = ");
    arr[i] = Convert.ToInt32(Console.ReadLine());
}

while(j < arr.Length) {
    if(arr[j] > max) {
        max = arr[j];
    }
    j ++;
}

Console.WriteLine($"\nmax of the array is: {max}");

max = arr[0];
foreach(int e in arr) {
    if(e > max) {
        max = e;
    }
}

Console.WriteLine($"\nmax of the array is: {max}");