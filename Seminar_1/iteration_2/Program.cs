// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

//вводим первое число, сохраняем в переменную
Console.Write("Input number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

//вводим второе число, сохраняем в переменную
Console.Write("Input number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

//добавили переменную q, можно без неё, тогда number_2 * number_2 нужно прописывать в if вместо q,,,
int q = number_2 * number_2;

//сравниваем
if (number_1 == q)
    Console.Write("a = " + number_1  + " b = " + number_2 + " -> " + "Yes");
else
{
    Console.Write("a = " + number_1  + " b = " + number_2 + " -> " + "No");
}
