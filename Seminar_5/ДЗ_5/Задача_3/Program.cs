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
    Console.Write("[");
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > max)
        {
            max = mass[i];
        }
        Console.Write($"{Math.Round(mass[i], 2)}, ");
    }
    Console.Write($"] -> {Math.Round(max, 2)}");
}
ShowArray(myMass);