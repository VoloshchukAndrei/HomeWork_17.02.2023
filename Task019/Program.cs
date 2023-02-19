Console.Write("Определение палиндрома, ведите число: ");
int number = int.Parse(Console.ReadLine()!);
int N = number;
int i = 0;
int count = 0;

int[] result = new int [N];

for (int j = 0; N >= 1; i++)
{
    result[j] = N % 10;
    N = N / 10;
    j++;
    count++;
}

for (int j = 0; j < count; j++)
{
    Console.Write($"{result[j]}");
}

//int number1 = (number / 10000);
//int number2 = (number / 1000) % 10;
//int number3 = (number / 100) % 10;
//int number4 = (number / 10) % 10;
//int number5 = (number % 10);

//if (number1 == number5 && number2 == number4)
//{
//    Console.WriteLine($"Число: {number}, является палиндромом");
//}
//else
//{
//    Console.WriteLine($"Число: {number}, не является палиндромом");
//}