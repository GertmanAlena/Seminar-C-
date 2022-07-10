// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
double[] NewArrey(int size, int min, int max)
{
    Random rnd = new Random();
    double[]  arrey = new double[size];
    for (int i = 0; i < size; i++)
    {
         arrey[i] = rnd.NextDouble()*(min-max)+min;
    }
   return arrey;
}
double[] myMass = NewArrey(10, 1, 5);
void ShowArray(double[] mass)
{
    double max = mass[0];
    double min = mass[0];
    double difference = max - min;
    Console.Write("[");
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > max)
        {
            max = mass[i];
        }
        // Console.Write($"{Math.Round(mass[i], 2)}, ");
        if (mass[i] < min)
        {
            min = mass[i];
        }
        Console.Write($"{Math.Round(mass[i], 2)}, ");
        
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine($"-> максимальное число {Math.Round(max, 2)}");
    Console.WriteLine($"-> минимальное число {Math.Round(min, 2)}");
    Console.WriteLine($"-> разница {Math.Round(max - min, 2)}");
}
ShowArray(myMass);