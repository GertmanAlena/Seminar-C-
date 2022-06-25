// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input number ");
Double number_1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number ");
Double number_2 = Convert.ToInt32(Console.ReadLine());

Double max = number_1;

if (number_2 > max)
   {
    Console.Write("a=" + number_1 + "; " + "b=" + number_2 + "; " + "-> " + " max=" + number_2);
   }
    else if (number_2 < max)
        {
            Console.Write("a=" + number_1 + "; " + "b=" + number_2 + "; " + "-> " + " max=" + max);
        }
else if (number_2 == max)
{
    Console.Write("a=" + number_1 + "; " + "b=" + number_2 + "; " + "-> " + " числа равны");
}