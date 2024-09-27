Console.Write("Введите целое число: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];
int i = 0;

while(i < arr.Length) {
    arr[i] = i + 1;
    Console.WriteLine($"arr[{i}] = {arr[i]}");
    i ++;
}