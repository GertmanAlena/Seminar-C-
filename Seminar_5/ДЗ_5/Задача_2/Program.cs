// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях

Console.Clear();
int[] RandArr(int size, int start, int end)
{
    int[] arrey = new int[size];
    for (int i = 0; i < size; i++)
    {
        arrey[i] = new Random().Next(start, end);
    }
    return arrey;
}
int[] myArrey = RandArr(10, 1, 100);

void ShowArray(int[] Mass)
{
    Console.Write("[");
    int Sum = 0;
    
    for (int i = 0; i < Mass.Length; i++)
    {
        Console.Write($"{Mass[i]},");
        int pos = i;
        if (pos % 2 == 0)
        {
            Sum += 0;
        }
        else
        {
            Sum += Mass[i];
        }
    }
    Console.WriteLine($"] -> {Sum}");
}
ShowArray(myArrey);