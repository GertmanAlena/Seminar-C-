// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
int[] CrRandomArey(int size, int min, int max)
{
    int[] arrey = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrey[i] = new Random().Next(min, max);
    }
    return arrey;
}
int[] myArrey = CrRandomArey(20, 100, 999);
void PrintArrey(int[] Mass)
{
    Console.Write("[");
    int counts = 0;
    for (int i = 0; i < Mass.Length; i++)
    {
        Console.Write($"{Mass[i]}, ");
        if (Mass[i] % 2 == 0)
        {
            counts += 1;
        }
    }
    Console.Write($"] -> {counts} ");
}
PrintArrey(myArrey);