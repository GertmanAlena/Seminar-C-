
int[] Mass(int volum, int start, int end)
{
    int[] RandomMass = new int[volum];
    for (int i = 0; i < volum; i++)
    {
        RandomMass[i] = new Random().Next(start, end+1);
    }
    return RandomMass;
}
void PrintMass(int[] arrey)
{
    int length = arrey.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{arrey[i]}, ");
    }
}

Console.WriteLine("Input size ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input min ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max ");
int max = Convert.ToInt32(Console.ReadLine());
int[] myRandom = Mass(size, min, max);
PrintMass(myRandom);