// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CRRandonArrey (int volum, int min, int max)
{
    int[] RandomArray = new int [volum];
    for (int i = 0; i < volum; i++)
    {
        RandomArray[i] = new Random().Next(min, max+1);
    }
    return RandomArray;
}
void PrintArrey (int[] arrey)
{
    int count = arrey.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write(arrey[i] + ", ");
    }
}

Console.Clear();

Console.WriteLine("количество элементов");
int lang = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите MIN");
int start = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите MAX");
int end = Convert.ToInt32(Console.ReadLine());
int[] myArrey = CRRandonArrey(lang, start, end);

PrintArrey(myArrey);
