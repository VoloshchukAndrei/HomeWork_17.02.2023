//Console.Clear();

Console.Write("Определение палиндрома, ведите число: ");
int N = int.Parse(Console.ReadLine()!);
int size = Quantity(N);
int i = 0;
int j = size - 1;
int[] array = Coup(N);

//Console.WriteLine($"[{String.Join(",", array)}]");

while (i < size / 2)
{
    if (array[i] == array[j])
    {
        i++;
        j--;
    }
    else
    {
        Console.WriteLine($"Число: {N}, не является палиндромом");
        return;
    }

}
Console.WriteLine($"Число: {N}, является палиндромом");

int Quantity(int N)
{
    int count = 0;
    if (N < 1)
    {
        N *= (-1);
    }
    while (N >= 1)
    {
        N = N / 10;
        count++;
    }
    return count;
}

int[] ZeroOneArray (int N)
{
    int[] result = new int[Quantity(N)];
    for (int i = 0; N >= 1; i++)
    {
        result[i] = N % 10;
        N = N / 10;
    }
       return result;
}

int[] Coup (int N)
{
    int[] result = ZeroOneArray(N);
    int j = Quantity(N) - 1;
    int b = result[i];
    for (int i = 0; i < Quantity(N) / 2; i++)
    {
        b = result[i];
        result[i] = result[j];
        result[j] = b;
        j = j - 1;
    }
        return result;
}