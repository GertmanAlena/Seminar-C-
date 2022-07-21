// Заполните спирально массив 4 на 4.

Console.Clear();
Console.Write("Введите размер матрицы: ");
int s = Convert.ToInt32(Console.ReadLine());
int[,] arr = GetArray(s);
PrintArray(arr);

int[,] GetArray(int size)
{
    int[,] result = new int[size, size];
    int i = 0;
    int j = 0;
    int rowE = size-1;
    int columnE = size-1;
    int rowS = 0;
    int columnS = 0;
    bool left = true;
    bool top = true;
    int count = 0;

    while (count < size*size) //все for делаем пока соличество шагов меньше количества элементов
    {
        count++;
        result[i, j] = count;
        //идём вправо
        if(left && top)
        {
            if (j == columnE)
            {
                rowS++;
                top = true;
                left = false;
                i++;
                continue;
            }
            else
            {
                j++;
                continue;
            }
        }
        //идём вниз
        if (!left && top)
        {
            if (i == rowE)
            {
                columnE--;
                top = false;
                left = false;
                j--;
                continue;
            }
            else
            {
                i++;
                continue;
            }
        }
        //идём влево
        if (!left && !top)
        {
            if(j == columnS)
            {
                rowE--;
                top = false;
                left = true;
                i--;
                continue;
            }
            else
            {
                j--;
                continue;
            }
        }
        //идём вверх
        if (left && !top)
        {
            if (i == rowS)
            {
                columnS++;
                top = true;
                left = true;
                j++;
                continue;
            }
            else
            {
                i--;
                continue;
            }
        }
    }
    return result;
}
void PrintArray(int[,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            Console.Write($"{mass[i,j]}\t");
        }
    Console.WriteLine();
    }
}
