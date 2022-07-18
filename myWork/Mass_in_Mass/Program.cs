// Задан прямоугольный массив названий и обозначений транспортных средств,
// (a – автомобиль, v – велосипед, m - мотоцикл, p – поезд, s – самолет).
// По введенному обозначению транспортного средства выводится его название

// string a = "avtomobile";
// string v = "velo";
// string m = "moto";
// string p = "train";
// string s = "plane";
// string[] avto = new string[] {a, v, m, p, s};

// Console.WriteLine("введите букву транспорта ");
// string? arg = Console.ReadLine();

// if (arg == "a") Console.Write($"a -> {a} \t");
// else if (arg == "v") Console.Write($"v -> {v} \t");
// else if (arg == "m") Console.Write($"m -> {m} \t");
// else if (arg == "p") Console.Write($"p -> {p} \t");
// else if (arg == "s") Console.Write($"s -> {s} \t");


// else Console.WriteLine($"{arg} -> такого транспорта нет \t");

//***           ***         ***         ***         ***
// Формируется и выводится прямоугольный массив (5 строк и 6 столбцов)
// целых случайных чисел от -40 до 40. Вычисляется и выводится: а) сумма
// чисел в каждой строке; б) среднее арифметическое чисел в каждой строке;

int[,] CreateArray()
{
    int[,] array = new int[5, 6];
    for (int rows = 0; rows < 5; rows++)
    {
        for (int columns = 0; columns < 6; columns++)
        {
            array[rows, columns] = new Random().Next(-40, 40);
        }
    }
    return array;
}

void ShowArray(int[,] mass)
{
    int Sum = 0;
    double ArithmeticMain = 0;
    for (int rows = 0; rows < mass.GetLength(0); rows++)
    {
        for (int columns = 0; columns < mass.GetLength(1); columns++)
        {
            Sum += mass[rows, columns];
            Console.Write($"{mass[rows, columns]} \t");
        }
        ArithmeticMain = Sum/mass.GetLength(1);
        Console.Write($" сумма = {Sum} -> {Math.Round(ArithmeticMain, 2)}");
        Console.WriteLine();
        Sum = 0;
    }
}
int[,] myArray = CreateArray();
ShowArray(myArray);