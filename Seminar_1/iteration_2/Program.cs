// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

//вводим первое число, сохраняем в переменную
Console.Write("Input number: ");
int number_1 = Convert.ToInt32(Console.ReadLine());

//вводим второе число, сохраняем в переменную
Console.Write("Input number: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

//
if (number_1 == number_2 * number_2)
    Console.Write("a =" + number_1  + "b =" + number_2 + "->"  + "->" + "Yes");
else
{
    Console.Write("a =" + number_1  + "b =" + number_2 + "->"  + "->" + "No");
}
