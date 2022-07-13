// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] myArrey()
{
    Console.Write("Введите количество элементов массива:\t ");
    int alementsCount = Convert.ToInt32(Console.ReadLine());
    int[] arrey = new int[alementsCount];

    for (int i = 0; i < arrey.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t ");
        arrey[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arrey;
}
void PrintMass(int[] inArray)
{

    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} ");
    }
}

int Cou(int[] mass)
{
    int counts = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > 0)
        {
            counts += 1;
        }
    }
    Console.Write($" -> {counts} ");
    return counts;

}
int[] array = myArrey();
PrintMass(array);
Cou(array);
