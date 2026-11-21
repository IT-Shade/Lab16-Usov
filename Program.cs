Console.Write("Введите размер массива: ");
int count = int.Parse(Console.ReadLine());

int[] arr = new int[count];

for (int i = 0; i < count; i++) {
    Console.Write($"Введите элемент {i + 1}: ");
    arr[i] = int.Parse(Console.ReadLine());
}

int sum = 0;
for (int i = 0; i < count; i++) {
    sum += arr[i];
}

Console.WriteLine($"Сумма элементов массива: {sum}");

int[] GenerateFibonacci(int n) {
    if (n <= 0) return new int[0];
    
    int[] fib = new int[n];
    if (n >= 1) fib[0] = 1;
    if (n >= 2) fib[1] = 1;

    for (int i = 2; i < n; i++) {
        fib[i] = fib[i - 1] + fib[i - 2];
    }

    return fib;
}

int[] result = GenerateFibonacci(10);
foreach (int num in result) {
    Console.Write(num + " ");
}