// отсортировать массив

int[] arr = {3, 1, 4, 3, 8, 6, 1, 1};

void PrintArrey(int[] array)  /*отдельный метод вывода массива на экран. Аргумент метода - наш массив*/
{
    int count = array.Length; /*выписываем числа до конца длины массива*/
    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
PrintArrey(arr);
void SelectionSort(int[] array)   /*отдельный метод упорядочить массив. Аргумент метода - наш массив*/
{
for(int i = 0; i < array.Length - 1; i++)  /*1. счётчик (перебираем массив)*/
    {
    int minPosition = i;                /*2. определили позицию первого элемента это [0]*/
    for(int j = i + 1; j < array.Length; j++)  /*4. ищем максимальный элемент? начиная с перой позиции +1*/
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
    int temporary = array[i];           /*3. меняем начальную позицию (это i=0) с той, которую нашли*/
    array[i] = array[minPosition];
    array[minPosition] = temporary;
    }
}

SelectionSort(arr);
PrintArrey(arr);