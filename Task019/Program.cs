Console.Write("Введите число от 10000 до 99999: ");
int number = int.Parse(Console.ReadLine()!);
int number1 = (number / 10000);
int number2 = (number / 1000) % 10;
int number3 = (number / 100) % 10;
int number4 = (number / 10) % 10;
int number5 = (number % 10);

if (number1 == number5 && number2 == number4)
{
    Console.WriteLine($"Число: {number}, является палиндромом");
}
else
{
    Console.WriteLine($"Число: {number}, не является палиндромом");
}