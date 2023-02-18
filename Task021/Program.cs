Console.Write("Введите X1: ");
double X1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y1: ");
double Y1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z1: ");
double Z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите X2: ");
double X2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y2: ");
double Y2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z2: ");
double Z2 = int.Parse(Console.ReadLine()!);

double distance3D = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2));

Console.WriteLine($"Расстояние между указанными точками в 3D пространстве = {distance3D:f2}");
