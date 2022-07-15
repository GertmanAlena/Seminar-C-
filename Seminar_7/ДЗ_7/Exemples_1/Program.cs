// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.Clear();
double[,] CreateArrey(int m, int n, int minVolume, int maxVolum){

    Random rnd = new Random();
    double[,] result = new double[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = rnd.NextDouble()*(minVolume - maxVolum)+maxVolum; 
        }
    }
    return result;
}

void PrintArray(double[,] mass){
    for (int rows = 0; rows < mass.GetLength(0); rows++)
    {
        for (int columns = 0; columns < mass.GetLength(1); columns++)
        {
            Console.Write($"{Math.Round(mass[rows,columns], 1)} \t");
        }
        Console.WriteLine();
        }
}

Console.Write("Input string -m- ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input column -n- ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] myArrey = CreateArrey(rows, columns, -5, 10);
PrintArray(myArrey);